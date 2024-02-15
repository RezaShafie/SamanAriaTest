namespace Saman.Application.Queries.User;

internal sealed record GetAllUsersQuery() : IQuery<List<Saman.Domain.Entities.User>>
{
}
