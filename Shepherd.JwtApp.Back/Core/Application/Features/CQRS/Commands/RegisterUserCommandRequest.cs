using MediatR;

namespace Shepherd.JwtApp.Back;
public class RegisterUserCommandRequest : IRequest
{
    public string? Username { get; set; }
    public string? Password { get; set; }
}
