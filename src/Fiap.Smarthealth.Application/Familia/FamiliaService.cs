using AutoMapper;
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
    private readonly IMapper _mapper;

    public FamiliaService(IFamiliaRepository familiaRepository, IMapper mapper)
    {
        _familiaRepository = familiaRepository;
        _mapper = mapper;
    }

    public async Task<List<FamiliaDTO>> GetAllAsync() =>
        _mapper.Map<List<FamiliaDTO>>(await _familiaRepository.GetAllAsync());

    public async Task<FamiliaDTO> CreateAsync(FamiliaDTO entityDTO)
    {
        var familia = await _familiaRepository.CreateAsync(_mapper.Map<Core.Domain.Familia>(entityDTO));
        return _mapper.Map<FamiliaDTO>(familia);
    }

    public async Task DeleteAsync(Guid id) => 
        await _familiaRepository.DeleteAsync(id);

    public async Task<FamiliaDTO> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<FamiliaDTO> UpdateAsync(FamiliaDTO entityDTO)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _familiaRepository?.Dispose();
    }
}
