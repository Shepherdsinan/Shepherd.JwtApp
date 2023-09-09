using System.Reflection;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shepherd.JwtApp.Back;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Persistance.Context;
using Shepherd.JwtApp.Back.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<JwtContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("Local"));
});  

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt=>{
    opt.AddProfiles(new List<Profile>(){

        new ProductProfile(),
        new CategoryProfile()
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
