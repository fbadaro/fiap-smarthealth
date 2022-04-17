using AutoMapper;
using Fiap.Smarthealth.Data.SQLServer.Repository.AgenteSaude;

namespace Fiap.Smarthealth.Application.AgenteSaude;

public class AgenteSaudeService : IAgenteSaudeService
{
    #region Properties

    private readonly IAgenteSaudeRepository _agenteSaudeRepository;
    private readonly IMapper _mapper;

    #endregion

    #region Constructor

    public AgenteSaudeService(IAgenteSaudeRepository agenteSaudeRepository, IMapper mapper)
    {
        _agenteSaudeRepository = agenteSaudeRepository;
        _mapper = mapper;
    }

    #endregion

    #region Public Methods

    public async Task<List<AgenteSaudeDTO>> GetAllAsync() => _mapper.Map<List<AgenteSaudeDTO>>(await _agenteSaudeRepository.GetAllAsync());

    public async Task<AgenteSaudeDTO> CreateAsync(AgenteSaudeDTO entityDTO)
    {
        var agenteSaude = await _agenteSaudeRepository.CreateAsync(_mapper.Map<Core.Domain.AgenteSaude>(entityDTO));
        return _mapper.Map<AgenteSaudeDTO>(agenteSaude);
    }

    public async Task DeleteAsync(Guid id) => await _agenteSaudeRepository.DeleteAsync(id);

    public async Task<AgenteSaudeDTO> GetById(Guid id) => _mapper.Map<AgenteSaudeDTO>(await _agenteSaudeRepository.GetById(id));

    public async Task<AgenteSaudeDTO> UpdateAsync(AgenteSaudeDTO entityDTO)
    {
        var agenteSaude = await _agenteSaudeRepository.UpdateAsync(_mapper.Map<Core.Domain.AgenteSaude>(entityDTO));
        return _mapper.Map<AgenteSaudeDTO>(agenteSaude);
    }

    public void Dispose()
    {
        _agenteSaudeRepository?.Dispose();
    } 

    #endregion
}
