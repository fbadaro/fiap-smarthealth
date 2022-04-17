using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class AgenteSaudeMapping : IEntityTypeConfiguration<AgenteSaude>
{
    public void Configure(EntityTypeBuilder<AgenteSaude> builder)
    {
        builder.ToTable("HT03_AGSAUDE");

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.OwnsOne(a => a.CPF, cpf =>
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

        builder.Property(b => b.Telefone)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(b => b.DataNascimento)
            .IsRequired();

        builder.OwnsOne(a => a.CNS, cns =>
        {
            cns.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(15);
        });           
    }
}
