﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Shepherd.JwtApp.Back;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IMediator mediator;

    public AuthController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Register(RegisterUserCommandRequest request)
    {
        await this.mediator.Send(request);
        return Created("",request);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login(CheckUserQueryRequest request)
    {
        var dto = await this.mediator.Send(request);
        if(dto.IsExist)
        {
            return Created("","token olustur");
        } 
        else
        {
            return BadRequest("Kullanıcı adı veya şifre hatali");
        }
    }
}
