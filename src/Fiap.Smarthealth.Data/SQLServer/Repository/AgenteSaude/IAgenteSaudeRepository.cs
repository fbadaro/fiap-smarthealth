using Fiap.Smarthealth.Data.Repository;

namespace Fiap.Smarthealth.Data.SQLServer.Repository.AgenteSaude;

/// <summary>
/// Used to apply custom methods of EFRepositoryBase
/// </summary>
public interface IAgenteSaudeRepository : IRepositoryBase<Core.Domain.AgenteSaude, Guid>
{
}
