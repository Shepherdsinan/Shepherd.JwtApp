using AutoMapper;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryListDto>().ReverseMap();
    }
}
