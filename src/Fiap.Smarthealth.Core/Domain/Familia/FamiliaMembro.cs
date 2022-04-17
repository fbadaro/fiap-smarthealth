using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class FamiliaMembro : Entity
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

    public string Nome { get; private set; } = default!;

    public string NomeSocial { get; private set; } = default!;

    public CPF CPF { get; private set; } = default!;

    public RG RG { get; private set; } = default!;

    public DateTime DataNascimento { get; private set; } = default!;

    public bool Responsavel { get; private set; } = default!;
}
