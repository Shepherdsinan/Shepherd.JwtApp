using MediatR;

namespace Shepherd.JwtApp.Back;
public class CreateCategoryCommandRequest : IRequest
{
    public string? Definition { get; set; }
}
