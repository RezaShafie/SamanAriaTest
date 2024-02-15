using Saman.Domain.Entities;

namespace Saman.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<User> UsersRepo { get; }
    IGenericRepository<Role> RolesRepo { get; }
    IGenericRepository<UserRole> UserRolesRepo { get; }
    Task CompleteAsync();
}
