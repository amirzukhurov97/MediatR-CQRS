using MediatR;

namespace MediatRCQRS.CQRS.Commands
{    
    public record CreateUserCommand(string Name) : IRequest<Guid>;
    
}
