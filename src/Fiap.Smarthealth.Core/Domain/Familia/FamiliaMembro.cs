using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class FamiliaMembro : Entity<Guid>
{
    public FamiliaMembro(string nome, string nomeSocial, CPF cPF, RG rG, DateTime dataNascimento, bool responsavel)
    {
        Nome = nome;
        NomeSocial = nomeSocial;
        CPF = cPF;
        RG = rG;
        DataNascimento = dataNascimento;
        Responsavel = responsavel;
    }

    public FamiliaMembro() { }

    public string Nome { get; private set; }

    public string NomeSocial { get; private set; }

    public CPF CPF { get; private set; }

    public RG RG { get; private set; }

    public DateTime DataNascimento { get; private set; }

    public bool Responsavel { get; private set; }
}
