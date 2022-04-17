using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class FamiliaMembroMapping : IEntityTypeConfiguration<FamiliaMembro>
{
    public void Configure(EntityTypeBuilder<FamiliaMembro> builder)
    {
        builder.ToTable("HT05_MEMBRO");

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(f => f.NomeSocial)
            .IsRequired()
            .HasMaxLength(150);

        builder.OwnsOne(f => f.CPF, cpf =>
        {
            cpf.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(11);

            cpf.Property(c => c.Emissor)
                .IsRequired()
                .HasMaxLength(5);

            cpf.Property(c => c.UF)
                .IsRequired()
                .HasMaxLength(2);
        });

        builder.OwnsOne(f => f.RG, rg =>
        {
            rg.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(15);
        });

        builder.Property(f => f.DataNascimento)
            .IsRequired();

        builder.Property(f => f.Responsavel)
            .IsRequired();
    }
}
