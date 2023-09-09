using AutoMapper;
using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;
    public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetAllAsync();
        return _mapper.Map<List<ProductListDto>>(data);
    }
}
