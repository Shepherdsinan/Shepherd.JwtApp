using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
{
    private readonly IRepository<Category> repository;

    public DeleteCategoryCommandHandler(IRepository<Category> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var deletedCategory = await this.repository.GetByIdAsync(request.Id);
        if(deletedCategory != null)
        {
            await this.repository.RemoveAsync(deletedCategory);
        }
        return Unit.Value;
    }
}
