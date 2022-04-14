using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class GeneroMapping : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Identificacao)
            .IsRequired()
            .HasMaxLength(50);
    }
}
