using AutoMapper;
using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoryListDto?>
{
    private readonly IRepository<Category> repository;
    private readonly IMapper mapper;
    public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<CategoryListDto?> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        var result = await this.repository.GetByFilterAsync(x=>x.Id == request.Id);
        return this.mapper.Map<CategoryListDto>(result);
    }
}
