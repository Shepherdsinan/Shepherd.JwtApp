using MediatR;

namespace Shepherd.JwtApp.Back;
public class DeleteProductCommandRequest : IRequest
{
    public int Id { get; set; }

    public DeleteProductCommandRequest(int id)
    {
        Id = id;
    }
}
