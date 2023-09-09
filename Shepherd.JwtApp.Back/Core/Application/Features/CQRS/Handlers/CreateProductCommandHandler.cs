using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
{
    private readonly IRepository<Product> _repository;

    public CreateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Product{
            Name = request.Name,
            Stock = request.Stock,
            Price = request.Price,
            CategoryId = request.CategoryId
        });
        return Unit.Value;
    }
}
