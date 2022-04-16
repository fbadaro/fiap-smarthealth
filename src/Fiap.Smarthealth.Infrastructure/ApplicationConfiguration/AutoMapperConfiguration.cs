using AutoMapper;
using Fiap.Smarthealth.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Smarthealth.Infrastructure.ApplicationConfiguration;

public static class AutoMapperConfiguration
{
    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddSingleton<IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
    }
}
