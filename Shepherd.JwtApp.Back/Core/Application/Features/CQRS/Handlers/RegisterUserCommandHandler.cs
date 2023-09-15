using MediatR;
using Shepherd.JwtApp.Back.Core.Application.Interfaces;
using Shepherd.JwtApp.Back.Core.Domain;

namespace Shepherd.JwtApp.Back;
public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
{
    private readonly IRepository<AppUser> repository;

    public RegisterUserCommandHandler(IRepository<AppUser> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
    {
        await this.repository.CreateAsync(new AppUser{
            Password = request.Password,
            Username = request.Username,
            AppRoleId = (int)RoleType.Member
        });
        return Unit.Value;
    }
}
