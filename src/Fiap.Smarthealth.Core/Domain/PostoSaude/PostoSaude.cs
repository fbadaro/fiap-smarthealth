using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class PostoSaude : IEntity<Guid>
{
    public PostoSaude(string nome, CNPJ cnpj, Endereco endereco, string telefone, string email, Funcionamento funcionamento)
    {
        Nome = nome;
        CNPJ = cnpj;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
        Funcionamento = funcionamento;
    }

    public PostoSaude() { }

    public Guid Id { get; set; } = default!;

    public string Nome { get; private set; } = default!;

    public CNPJ CNPJ { get; private set; } = default!;

    public Endereco Endereco { get; private set; } = default!;

    public string Telefone { get; private set; } = default!;

    public string Email { get; private set; } = default!;

    public Funcionamento Funcionamento { get; private set; } = default!;
}
