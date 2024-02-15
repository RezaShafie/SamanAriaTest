using Saman.Domain.Entities;

namespace Saman.Domain.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : IEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(Guid id);
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
