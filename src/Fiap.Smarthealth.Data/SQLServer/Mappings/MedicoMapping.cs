using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class MedicoMapping : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.OwnsOne(m => m.CPF, cpf =>
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

        builder.OwnsOne(m => m.CNPJ, cnpj =>
        {
            cnpj.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(14);

            cnpj.Property(c => c.Emissor)
                .IsRequired()
                .HasMaxLength(5);
        });

        builder.OwnsOne(m => m.CRM, crm =>
        {
            crm.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(10);

            crm.Property(c => c.UF)
                .IsRequired()
                .HasMaxLength(2);
        });

        builder.Property(m => m.Telefone)
           .IsRequired()
           .HasMaxLength(14);

        builder.Property(m => m.DataNascimento)
            .IsRequired();
    }
}
