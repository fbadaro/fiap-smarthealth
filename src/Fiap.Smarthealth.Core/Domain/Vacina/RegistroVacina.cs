using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class RegistroVacina : Entity
{
    public RegistroVacina(string nome, DateTime dataAplicacao, DateTime? vencimento)
    {
        Nome = nome;
        DataAplicacao = dataAplicacao;
        Vencimento = vencimento;
    }

    public RegistroVacina() { }    

    public string Nome { get; private set; } = default!;

    public DateTime DataAplicacao { get; private set; } = default!;

    public DateTime? Vencimento { get; private set; } = null;
}
