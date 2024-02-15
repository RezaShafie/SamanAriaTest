using Saman.Domain.Entities;
using Saman.Domain.Interfaces;
using Saman.Infra.Data;

namespace Saman.Infra.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public IGenericRepository<User> UsersRepo { get; private set; }

    public IGenericRepository<Role> RolesRepo { get; private set; }

    public IGenericRepository<UserRole> UserRolesRepo { get; private set; }

    public UnitOfWork(IGenericRepository<User> usersRepo, IGenericRepository<Role> rolesRepo, IGenericRepository<UserRole> userRolesRepo, AppDbContext context)
    {

        _context = context;

        UsersRepo = new GenericRepository<User>(_context);
        RolesRepo = new GenericRepository<Role>(_context);
        UserRolesRepo = new GenericRepository<UserRole>(_context);
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
