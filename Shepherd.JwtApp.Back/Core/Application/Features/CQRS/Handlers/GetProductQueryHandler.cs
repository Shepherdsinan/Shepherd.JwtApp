

using AutoMapper;
using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
{
    private readonly IRepository<Product> _productRepository;
    private readonly IMapper _mapper;

    public GetProductQueryHandler(IRepository<Product> productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
    {
        var data = await _productRepository.GetByFilterAsync(x=>x.Id == request.Id);
        return _mapper.Map<ProductListDto>(data);
    }
}
