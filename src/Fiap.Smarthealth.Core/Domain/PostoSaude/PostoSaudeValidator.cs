using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain
{
    public class PostoSaudeValidator : IEntityValidator<PostoSaude, Guid>
    {
        public Task<EntityValidationResult> Validate(EntityValidationType validationType, PostoSaude entity)
        {
            throw new NotImplementedException();
        }
    }
}
