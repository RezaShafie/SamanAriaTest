
namespace Saman.Application.Queries.User;

internal class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, List<Saman.Domain.Entities.User>>
{
    public Task<List<Domain.Entities.User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
