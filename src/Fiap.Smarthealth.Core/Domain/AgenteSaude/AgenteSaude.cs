using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class AgenteSaude : Entity
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

    public string Nome { get; private set; } = default!;

    public CPF CPF { get; private set; } = default!;

    public string Telefone { get; private set; } = default!;

    public DateTime DataNascimento { get; private set; } = default!;

    public CNS CNS { get; private set; } = default!;
}
