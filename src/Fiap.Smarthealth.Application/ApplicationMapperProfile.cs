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
        CreateMap<FamiliaDTO, Core.Domain.Familia>();
    }
}