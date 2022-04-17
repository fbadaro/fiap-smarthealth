using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class RegistroVacinaMapping : IEntityTypeConfiguration<RegistroVacina>
{
    public void Configure(EntityTypeBuilder<RegistroVacina> builder)
    {
        builder.ToTable("HT06_REGVACI");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(r => r.DataAplicacao)
            .IsRequired();

        builder.Property(r => r.Vencimento);            
    }
}
