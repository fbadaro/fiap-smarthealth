using AutoMapper;
using Fiap.Smarthealth.Data.SQLServer.Repository.PostoSaude;

namespace Fiap.Smarthealth.Application.PostoSaude;

public class PostoSaudeService : IPostoSaudeService
{
    #region Properties

    private readonly IPostoSaudeRepository _postoSaudeRepository;
    private readonly IMapper _mapper;

    #endregion

    #region Constructor

    public PostoSaudeService(IPostoSaudeRepository postoSaudeRepository, IMapper mapper)
    {
        _postoSaudeRepository = postoSaudeRepository;
        _mapper = mapper;
    }

    #endregion

    #region Public Methods

    public async Task<List<PostoSaudeDTO>> GetAllAsync() => _mapper.Map<List<PostoSaudeDTO>>(await _postoSaudeRepository.GetAllAsync());

    public async Task<PostoSaudeDTO> CreateAsync(PostoSaudeDTO entityDTO)
    {        
        var postoSaude = await _postoSaudeRepository.CreateAsync(_mapper.Map<Core.Domain.PostoSaude>(entityDTO));
        return _mapper.Map<PostoSaudeDTO>(postoSaude);
    }

    public async Task DeleteAsync(Guid id) => await _postoSaudeRepository.DeleteAsync(id);


    public async Task<PostoSaudeDTO> GetById(Guid id) => _mapper.Map<PostoSaudeDTO>(await _postoSaudeRepository.GetById(id));

    public async Task<PostoSaudeDTO> UpdateAsync(PostoSaudeDTO entityDTO)
    {
        var postoSaude = await _postoSaudeRepository.UpdateAsync(_mapper.Map<Core.Domain.PostoSaude>(entityDTO));
        return _mapper.Map<PostoSaudeDTO>(postoSaude);
    }

    public void Dispose() => _postoSaudeRepository?.Dispose();

    #endregion
}
