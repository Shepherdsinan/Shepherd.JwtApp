using AutoMapper;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product,ProductListDto>().ReverseMap();
    }
}
