using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Fiap.Smarthealth.Data.SQLServer;

public class SmarthealthDBContext : DbContext
{
    public SmarthealthDBContext(DbContextOptions<SmarthealthDBContext> options) 
        : base(options)
    {

    }
    
    public DbSet<AgenteSaude> AgentesSaude { get; set; } = null!;

    public DbSet<Familia> Familias { get; set; } = null!;

    public DbSet<FamiliaMembro> Membros { get; set; } = null!;

    public DbSet<Genero> Generos { get; set; } = null!;

    public DbSet<Medico> Medicos { get; set; } = null!;

    public DbSet<MedicoEspecialidade> Especialidades { get; set; } = null!;

    public DbSet<PostoSaude> PostosSaude { get; set; } = null!;

    public DbSet<RegistroVacina> Vacinas { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmarthealthDBContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.Smarthealth.Api/appsettings.json")
                .Build();
        
        optionsBuilder.UseSqlServer(configuration["SqlServer:ConnectionString"], opt =>
            opt.MigrationsHistoryTable("MigrationSmarthealthContext"));
    }
}