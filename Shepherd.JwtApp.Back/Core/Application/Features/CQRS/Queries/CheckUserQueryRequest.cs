using MediatR;

namespace Shepherd.JwtApp.Back;
public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;

}
