using Fiap.Smarthealth.Data.Repository;

namespace Fiap.Smarthealth.Data.SQLServer.Repository.Familia;

/// <summary>
/// Used to apply custom methods of EFRepositoryBase
/// </summary>
public interface IFamiliaRepository : IRepositoryBase<Core.Domain.Familia, Guid>
{
}