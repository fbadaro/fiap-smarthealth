namespace Fiap.Smarthealth.Core.Entities
{
    public interface IEntityValidator<TEntity, TKey> where TEntity : Entity<TKey>
    {
        Task<EntityValidationResult> Validate(EntityValidationType validationType, TEntity entity);
    }
}
