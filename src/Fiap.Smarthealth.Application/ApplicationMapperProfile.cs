using AutoMapper;
using Fiap.Smarthealth.Application.AgenteSaude;
using Fiap.Smarthealth.Application.Familia;
using Fiap.Smarthealth.Application.PostoSaude;

namespace Fiap.Smarthealth.Application;

public class AutoMapperConfig
{
    protected AutoMapperConfig() { }

    public static MapperConfiguration RegisterMappings() =>
        new MapperConfiguration(config =>
        {
            config.AllowNullCollections = true;
            config.AddProfile(new ApplicationProfileMapper());
        });
}

public class ApplicationProfileMapper : Profile
{
    public ApplicationProfileMapper()
    {
        // Familia Map
        CreateMap<Core.Domain.Familia, FamiliaDTO>()
            .ForMember(dto => dto.CNSNumero, opt => opt.MapFrom(familia => familia.CNS.Numero))
            .ForMember(dto => dto.EnderecoLogradouro, opt => opt.MapFrom(familia => familia.Endereco.Logradouro))
            .ForMember(dto => dto.EnderecoComplemento, opt => opt.MapFrom(familia => familia.Endereco.Complemento))
            .ForMember(dto => dto.EnderecoBairro, opt => opt.MapFrom(familia => familia.Endereco.Bairro))
            .ForMember(dto => dto.EnderecoCEP, opt => opt.MapFrom(familia => familia.Endereco.CEP));

        CreateMap<FamiliaDTO, Core.Domain.Familia>()
            .ForPath(familia => familia.CNS.Numero, opt => opt.MapFrom(dto => dto.CNSNumero))
            .ForPath(familia => familia.Endereco.Logradouro, opt => opt.MapFrom(dto => dto.EnderecoLogradouro))
            .ForPath(familia => familia.Endereco.Complemento, opt => opt.MapFrom(dto => dto.EnderecoComplemento))
            .ForPath(familia => familia.Endereco.Bairro, opt => opt.MapFrom(dto => dto.EnderecoBairro))
            .ForPath(familia => familia.Endereco.CEP, opt => opt.MapFrom(dto => dto.EnderecoCEP));

        // Agente Saude Map
        CreateMap<Core.Domain.AgenteSaude, AgenteSaudeDTO>()
            .ForMember(dto => dto.CNSNumero, opt => opt.MapFrom(familia => familia.CNS.Numero))
            .ForMember(dto => dto.CPFNumero, opt => opt.MapFrom(familia => familia.CPF.Numero))
            .ForMember(dto => dto.CPFEmissor, opt => opt.MapFrom(familia => familia.CPF.Emissor))
            .ForMember(dto => dto.CPFUF, opt => opt.MapFrom(familia => familia.CPF.UF));

        CreateMap<AgenteSaudeDTO, Core.Domain.AgenteSaude>()
            .ForPath(agente => agente.CNS.Numero, opt => opt.MapFrom(dto => dto.CNSNumero))
            .ForPath(agente => agente.CPF.Numero, opt => opt.MapFrom(dto => dto.CPFNumero))
            .ForPath(agente => agente.CPF.Emissor, opt => opt.MapFrom(dto => dto.CPFEmissor))
            .ForPath(agente => agente.CPF.UF, opt => opt.MapFrom(dto => dto.CPFUF));

        // Posto Saude Map
        CreateMap<Core.Domain.PostoSaude, PostoSaudeDTO>()
            .ForMember(dto => dto.CNPJNumero, opt => opt.MapFrom(posto => posto.CNPJ.Numero))
            .ForMember(dto => dto.CNPJEmissor, opt => opt.MapFrom(posto => posto.CNPJ.Emissor))
            .ForMember(dto => dto.FuncionamentoAbertura, opt => opt.MapFrom(posto => posto.Funcionamento.Abertura))
            .ForMember(dto => dto.FuncionamentoEncerramento, opt => opt.MapFrom(posto => posto.Funcionamento.Encerramento))
            .ForMember(dto => dto.EnderecoLogradouro, opt => opt.MapFrom(posto => posto.Endereco.Logradouro))
            .ForMember(dto => dto.EnderecoComplemento, opt => opt.MapFrom(posto => posto.Endereco.Complemento))
            .ForMember(dto => dto.EnderecoBairro, opt => opt.MapFrom(posto => posto.Endereco.Bairro))
            .ForMember(dto => dto.EnderecoCEP, opt => opt.MapFrom(posto => posto.Endereco.CEP));

        CreateMap<PostoSaudeDTO, Core.Domain.PostoSaude>()
            .ForPath(posto => posto.CNPJ.Numero, opt => opt.MapFrom(posto => posto.CNPJNumero))
            .ForPath(posto => posto.CNPJ.Emissor, opt => opt.MapFrom(posto => posto.CNPJEmissor))
            .ForPath(posto => posto.Funcionamento.Abertura, opt => opt.MapFrom(posto => posto.FuncionamentoAbertura))
            .ForPath(posto => posto.Funcionamento.Encerramento, opt => opt.MapFrom(posto => posto.FuncionamentoEncerramento))
            .ForPath(posto => posto.Endereco.Logradouro, opt => opt.MapFrom(posto => posto.EnderecoLogradouro))
            .ForPath(posto => posto.Endereco.Complemento, opt => opt.MapFrom(posto => posto.EnderecoComplemento))
            .ForPath(posto => posto.Endereco.Bairro, opt => opt.MapFrom(posto => posto.EnderecoBairro))
            .ForPath(posto => posto.Endereco.CEP, opt => opt.MapFrom(posto => posto.EnderecoCEP));
    }
}