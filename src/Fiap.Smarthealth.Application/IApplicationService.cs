namespace Fiap.Smarthealth.Application;

public interface IApplicationService<TEntityDTO> : IDisposable where TEntityDTO : EntityDTO
{
    Task<List<TEntityDTO>> GetAllAsync();

    Task<TEntityDTO> GetById(Guid id);

    Task<TEntityDTO> CreateAsync(TEntityDTO entity);

    Task<TEntityDTO> UpdateAsync(TEntityDTO entity);

    Task DeleteAsync(TEntityDTO entity);    
}
