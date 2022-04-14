using Fiap.Smarthealth.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Smarthealth.Data.SQLServer.Mappings;

public class PostoSaudeMapping : IEntityTypeConfiguration<PostoSaude>
{
    public void Configure(EntityTypeBuilder<PostoSaude> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.OwnsOne(p => p.CNPJ, cnpj =>
        {
            cnpj.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(14);

            cnpj.Property(c => c.Emissor)
                .IsRequired()
                .HasMaxLength(5);
        });

        builder.OwnsOne(p => p.Endereco, endereco =>
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

        builder.Property(m => m.Telefone)
           .IsRequired()
           .HasMaxLength(14);

        builder.Property(f => f.Email)
            .IsRequired()
            .HasMaxLength(30);

        builder.OwnsOne(p => p.Funcionamento, func =>
        {
            func.Property(c => c.Abertura)
                .IsRequired();

            func.Property(c => c.Encerramento)
                .IsRequired();                
        });
    }
}
