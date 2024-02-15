namespace Saman.Application.Queries.User;

internal sealed record GetUserByIdQuery(Guid userId) : IQuery<Saman.Domain.Entities.User>
{
}
