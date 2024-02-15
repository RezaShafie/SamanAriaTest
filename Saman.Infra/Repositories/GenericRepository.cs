using Microsoft.EntityFrameworkCore;
using Saman.Domain.Entities;
using Saman.Domain.Interfaces;
using Saman.Infra.Data;

namespace Saman.Infra.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : IEntity
{
    protected readonly AppDbContext _context;

    public GenericRepository(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TEntity>().Where(e => e.Id == id).FirstOrDefaultAsync();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }
}
