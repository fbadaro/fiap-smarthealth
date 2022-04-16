using Fiap.Smarthealth.Data.SQLServer.Repository.Familia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Smarthealth.Application.Familia;

public class FamiliaService : IFamiliaService
{
    private readonly IFamiliaRepository _familiaRepository;

    public FamiliaService(IFamiliaRepository familiaRepository)
    {
        _familiaRepository = familiaRepository;
    }

    public async Task<FamiliaDTO> CreateAsync(FamiliaDTO entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(FamiliaDTO entity)
    {
        throw new NotImplementedException();
    }   

    public async Task<List<FamiliaDTO>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<FamiliaDTO> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<FamiliaDTO> UpdateAsync(FamiliaDTO entity)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _familiaRepository?.Dispose();
    }
}
