using MediatR;
using MediatRCQRS.CQRS.Commands;
using MediatRCQRS.Models;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly List<User> _users;

    public CreateUserCommandHandler(List<User> users)
    {
        _users = users;
    }

    public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User { Id = Guid.NewGuid(), Name = request.Name };
        _users.Add(user);
        return Task.FromResult(user.Id);
    }
}