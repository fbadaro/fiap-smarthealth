namespace Fiap.Smarthealth.Data.SQLServer.Repository.PostoSaude;

public class PostoSaudeRepository : RepositorySQLBase<Core.Domain.PostoSaude, Guid>, IPostoSaudeRepository
{
    public PostoSaudeRepository(SmarthealthDBContext context) : base(context)
    {
    }
}
