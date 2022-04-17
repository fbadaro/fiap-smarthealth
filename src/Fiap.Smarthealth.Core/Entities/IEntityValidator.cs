namespace Fiap.Smarthealth.Core.Entities;

public interface IEntityValidator<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
{
    Task<EntityValidationResult> Validate(EntityValidationType validationType, TEntity entity);
}
