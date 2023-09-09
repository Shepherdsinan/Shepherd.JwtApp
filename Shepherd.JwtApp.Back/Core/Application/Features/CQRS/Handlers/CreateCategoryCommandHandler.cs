using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest>
{
    private readonly IRepository<Category> repository;

    public CreateCategoryCommandHandler(IRepository<Category> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        await this.repository.CreateAsync(new Category{
            Definition = request.Definition
        });
        return Unit.Value;
    }
}
