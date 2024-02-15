
namespace Saman.Application.Queries.User;

internal class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, Saman.Domain.Entities.User>
{
    public Task<Domain.Entities.User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
