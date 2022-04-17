using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class Medico : Entity
{
    public Medico(string nome, CPF cPF, CNPJ cNPJ, CRM cRM, string telefone, DateTime dataNascimento)
    {
        Nome = nome;
        CPF = cPF;
        CNPJ = cNPJ;
        CRM = cRM;
        Telefone = telefone;
        DataNascimento = dataNascimento;
    }

    public Medico() { }    

    public string Nome { get; private set; } = default!;

    public CPF CPF { get; private set; } = default!;

    public CNPJ CNPJ { get; private set; } = default!;

    public CRM CRM { get; private set; } = default!;

    public string Telefone { get; private set; } = default!;

    public DateTime DataNascimento { get; private set; } = default!;
}
