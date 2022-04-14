using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class MedicoEspecialidadeMapping : IEntityTypeConfiguration<MedicoEspecialidade>
{
    public void Configure(EntityTypeBuilder<MedicoEspecialidade> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Especialidade)
            .IsRequired()
            .HasMaxLength(150);
    }
}
