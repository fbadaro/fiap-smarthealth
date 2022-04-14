namespace Fiap.Smarthealth.Application;

public interface IApplicationService<T> : IDisposable where T : EntityDTO
{
    Task<List<T>> GetAllAsync();

    Task<T> GetById(Guid id);

    Task<T> CreateAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(T entity);    
}
