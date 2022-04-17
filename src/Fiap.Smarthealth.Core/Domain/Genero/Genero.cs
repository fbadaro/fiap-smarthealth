using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class Genero : Entity
{
    public Genero(string identificacao)
    {
        Identificacao = identificacao;
    }

    public Genero() { }    

    public string Identificacao { get; private set; } = default!;
}
