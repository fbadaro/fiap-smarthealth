namespace Fiap.Smarthealth.Data.SQLServer;

public interface IEntityCoreContext<TEntity, TDBContext>
{
    Task<TEntity> GetDBSetAsync(TEntity entity);

    Task<TEntity> GetDBContextAsync(TEntity entity, TDBContext context);
}
