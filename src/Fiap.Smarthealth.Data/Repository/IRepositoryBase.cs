using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Data.Repository;

public interface IRepositoryBase<TEntity, TPrimaryKey> : IDisposable where TEntity : class, IEntity<TPrimaryKey>
{
    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<TEntity> GetById(Guid id);

    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task DeleteAsync(TEntity entity);
}
