using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
{
    private readonly IRepository<Product> _repository;

    public UpdateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var updateProduct = await _repository.GetByIdAsync(request.Id);
        if (updateProduct != null)
        {
            updateProduct.CategoryId = request.CategoryId;
            updateProduct.Stock = request.Stock;
            updateProduct.Price = request.Price;
            updateProduct.Name = request.Name;
            await _repository.UpdateAsync(updateProduct);
        }
        return Unit.Value;
    }
}
