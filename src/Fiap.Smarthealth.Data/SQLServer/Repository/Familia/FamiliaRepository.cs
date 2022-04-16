using Fiap.Smarthealth.Data.SQLServer.Repository.Familia;

namespace Fiap.Smarthealth.Data.SQLServer.Repository
{
    public class FamiliaRepository : RepositorySQLBase<Core.Domain.Familia, Guid>, IFamiliaRepository
    {
        public FamiliaRepository(SmarthealthDBContext context) : base(context)
        {
        }
    }
}
