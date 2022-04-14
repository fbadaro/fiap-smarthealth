using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class FamiliaMapping : IEntityTypeConfiguration<Familia>
{
    public void Configure(EntityTypeBuilder<Familia> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Sobrenome)
            .IsRequired()
            .HasMaxLength(150);

        builder.OwnsOne(f => f.CNS, cns =>
        {
            cns.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(15);
        });

        builder.OwnsOne(f => f.Endereco, endereco =>
        {
            endereco.Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            endereco.Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(30);

            endereco.Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(150);

            endereco.Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(9);
        });

        builder.Property(f => f.Telefone)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(f => f.Email)
            .IsRequired()
            .HasMaxLength(30);
    }
}
