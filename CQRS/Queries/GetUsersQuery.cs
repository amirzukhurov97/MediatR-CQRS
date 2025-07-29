using MediatR;
using MediatRCQRS.Models;

public record GetUsersQuery() : IRequest<List<User>>;