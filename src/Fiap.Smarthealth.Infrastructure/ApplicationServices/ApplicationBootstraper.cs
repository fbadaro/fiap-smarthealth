using Fiap.Smarthealth.Application.AgenteSaude;
using Fiap.Smarthealth.Application.Familia;
using Fiap.Smarthealth.Core.Domain;
using Fiap.Smarthealth.Data.Repository;
using Fiap.Smarthealth.Data.SQLServer;
using Fiap.Smarthealth.Data.SQLServer.Repository;
using Fiap.Smarthealth.Data.SQLServer.Repository.AgenteSaude;
using Fiap.Smarthealth.Data.SQLServer.Repository.Familia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Smarthealth.Infrastructure.ApplicationServices;

public static class ApplicationBootstraper
{
    public static void AddDBContextApplication(this IServiceCollection services)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.Smarthealth.Api/appsettings.json")
                .Build();

        services.AddDbContext<SmarthealthDBContext>(options =>
               options.UseSqlServer(configuration["SqlServer:ConnectionString"]));
    }

    public static void AddServiceApplication(this IServiceCollection services)
    {
        // Familia Service/Repository
        services.AddScoped<IFamiliaService, FamiliaService>();
        services.AddScoped<IFamiliaRepository, FamiliaRepository>();
        services.AddScoped<IRepositoryBase<Familia, Guid>, RepositorySQLBase<Familia, Guid>>();

        // Agente Saude Service/Repository
        services.AddScoped<IAgenteSaudeService, AgenteSaudeService>();
        services.AddScoped<IAgenteSaudeRepository, AgenteSaudeRepository>();
        services.AddScoped<IRepositoryBase<AgenteSaude, Guid>, RepositorySQLBase<AgenteSaude, Guid>>();

        // DBContext
        services.AddScoped<DbContext>();
    }
}
