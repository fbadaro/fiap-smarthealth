using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class AgenteSaude : Entity<Guid>
{
    public AgenteSaude(string nome, CPF cpf, string telefone, DateTime dataNascimento, CNS cns)
    {
        Nome = nome;
        CPF = cpf;
        Telefone = telefone;
        DataNascimento = dataNascimento;
        CNS = cns;
    }

    public AgenteSaude () { }

    public string Nome { get; private set; }

    public CPF CPF { get; private set; }

    public string Telefone { get; private set; }

    public DateTime DataNascimento { get; private set; }

    public CNS CNS { get; private set; }
}
