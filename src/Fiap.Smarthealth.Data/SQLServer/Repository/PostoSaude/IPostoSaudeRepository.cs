using Fiap.Smarthealth.Data.Repository;

namespace Fiap.Smarthealth.Data.SQLServer.Repository.PostoSaude;

/// <summary>
/// Used to apply custom methods of EFRepositoryBase
/// </summary>
public interface IPostoSaudeRepository : IRepositoryBase<Core.Domain.PostoSaude, Guid>
{
}
