namespace Fiap.Smarthealth.Data.SQLServer.Repository.AgenteSaude;

public class AgenteSaudeRepository : RepositorySQLBase<Core.Domain.AgenteSaude, Guid>, IAgenteSaudeRepository
{
    public AgenteSaudeRepository(SmarthealthDBContext context) : base(context)
    {
    }
}
