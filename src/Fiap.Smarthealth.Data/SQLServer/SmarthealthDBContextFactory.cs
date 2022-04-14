using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Fiap.Smarthealth.Data.SQLServer;

public class SmarthealthDBContextFactory : IDesignTimeDbContextFactory<SmarthealthDBContext>
{
    public SmarthealthDBContext CreateDbContext(string[] args)
    {
        try
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.Smarthealth.Api/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<SmarthealthDBContext>();            
            builder.UseSqlServer(configuration["SqlServer:ConnectionString"], opt =>            
                opt.MigrationsHistoryTable("MigrationSmarthealthContext"));

            return new SmarthealthDBContext(builder.Options);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
