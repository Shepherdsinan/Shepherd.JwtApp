using MediatR;

namespace Shepherd.JwtApp.Back;
public class UpdateCategoryCommandRequest : IRequest
{
    public int Id { get; set; }
    public string? Definition { get; set; }
}
