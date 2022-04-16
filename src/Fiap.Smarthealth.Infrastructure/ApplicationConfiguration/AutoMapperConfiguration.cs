using AutoMapper;
using Fiap.Smarthealth.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Smarthealth.Infrastructure.ApplicationConfiguration;

public static class AutoMapperConfiguration
{
    public static void AddAutoMapperApplication(this IServiceCollection services, params System.Reflection.Assembly[] assemblies)
    {
        services.AddAutoMapper(assemblies);
        services.AddSingleton<IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
    }
}
