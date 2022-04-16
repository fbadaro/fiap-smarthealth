using AutoMapper;
using Fiap.Smarthealth.Data.SQLServer.Repository.Familia;

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

    public async Task<List<FamiliaDTO>> GetAllAsync() => _mapper.Map<List<FamiliaDTO>>(await _familiaRepository.GetAllAsync());

    public async Task<FamiliaDTO> CreateAsync(FamiliaDTO entityDTO)
    {
        var familia = await _familiaRepository.CreateAsync(_mapper.Map<Core.Domain.Familia>(entityDTO));
        return _mapper.Map<FamiliaDTO>(familia);
    }

    public async Task DeleteAsync(Guid id) => await _familiaRepository.DeleteAsync(id);

    public async Task<FamiliaDTO> GetById(Guid id) => _mapper.Map<FamiliaDTO>(await _familiaRepository.GetById(id));

    public async Task<FamiliaDTO> UpdateAsync(FamiliaDTO entityDTO)
    {
        var familia = await _familiaRepository.UpdateAsync(_mapper.Map<Core.Domain.Familia>(entityDTO));
        return _mapper.Map<FamiliaDTO>(familia);
    }

    public void Dispose()
    {
        _familiaRepository?.Dispose();
    }
}
