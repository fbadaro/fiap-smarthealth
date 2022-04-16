using AutoMapper;
using Fiap.Smarthealth.Application.Familia;

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
        CreateMap<Core.Domain.Familia, FamiliaDTO>()
            .ForMember(dto => dto.CNS, opt => opt.MapFrom(familia => familia.CNS.Numero))
            .ForMember(dto => dto.Logradouro, opt => opt.MapFrom(familia => familia.Endereco.Logradouro))
            .ForMember(dto => dto.Complemento, opt => opt.MapFrom(familia => familia.Endereco.Complemento))
            .ForMember(dto => dto.Bairro, opt => opt.MapFrom(familia => familia.Endereco.Bairro))
            .ForMember(dto => dto.CEP, opt => opt.MapFrom(familia => familia.Endereco.CEP));        

        CreateMap<FamiliaDTO, Core.Domain.Familia>()
            .ForPath(familia => familia.CNS.Numero, opt => opt.MapFrom(dto => dto.CNS))
            .ForPath(familia => familia.Endereco.Logradouro, opt => opt.MapFrom(dto => dto.Logradouro))
            .ForPath(familia => familia.Endereco.Complemento, opt => opt.MapFrom(dto => dto.Complemento))
            .ForPath(familia => familia.Endereco.Bairro, opt => opt.MapFrom(dto => dto.Bairro))
            .ForPath(familia => familia.Endereco.CEP, opt => opt.MapFrom(dto => dto.CEP));
    }
}