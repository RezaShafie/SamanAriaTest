using Saman.Domain.Interfaces;
using Saman.Domain.Models;

namespace Saman.Infra.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<User> UsersRepo { get; }
    IGenericRepository<Role> RolesRepo { get; }
    IGenericRepository<UserRole> UserRolesRepo { get; }
    Task CompleteAsync();
}
