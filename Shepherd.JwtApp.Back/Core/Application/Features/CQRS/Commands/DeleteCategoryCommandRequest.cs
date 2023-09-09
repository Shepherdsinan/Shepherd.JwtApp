using MediatR;

namespace Shepherd.JwtApp.Back;
public class DeleteCategoryCommandRequest : IRequest
{
    public int Id { get; set; }

    public DeleteCategoryCommandRequest(int id)
    {
        Id = id;
    }
}
