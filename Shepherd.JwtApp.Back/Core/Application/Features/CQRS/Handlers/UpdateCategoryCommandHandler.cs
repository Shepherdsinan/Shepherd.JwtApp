using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;


namespace Shepherd.JwtApp.Back;
public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
{
    private readonly IRepository<Category> repository;

    public UpdateCategoryCommandHandler(IRepository<Category> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var updateCategory = await this.repository.GetByIdAsync(request.Id);
        if(updateCategory != null)
        {
            updateCategory.Definition = request.Definition;
            await this.repository.UpdateAsync(updateCategory);
        }
        return Unit.Value;
    }
}
