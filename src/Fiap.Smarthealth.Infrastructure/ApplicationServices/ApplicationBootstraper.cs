using Fiap.Smarthealth.Application.Familia;
using Fiap.Smarthealth.Core.Domain;
using Fiap.Smarthealth.Data.Repository;
using Fiap.Smarthealth.Data.SQLServer;
using Fiap.Smarthealth.Data.SQLServer.Repository;
using Fiap.Smarthealth.Data.SQLServer.Repository.Familia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Smarthealth.Infrastructure.ApplicationServices;

public static class ApplicationBootstraper
{
    public static void AddServiceApplication(this IServiceCollection services)
    {
        services.AddSingleton<DbContext, SmarthealthDBContext>();
        services.AddScoped<IFamiliaService, FamiliaService>();
        services.AddScoped<IFamiliaRepository, FamiliaRepository>();
        services.AddScoped<IRepositoryBase<Familia, Guid>, RepositorySQLBase<Familia, Guid>>();                               
    }
}
