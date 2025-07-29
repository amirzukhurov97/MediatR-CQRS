// Features/Users/Handlers/GetUsersQueryHandler.cs
using MediatR;
using MediatRCQRS.Models;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<User>>
{
    private readonly List<User> _users;

    public GetUsersQueryHandler(List<User> users)
    {
        _users = users;
    }

    public Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_users);
    }
}
