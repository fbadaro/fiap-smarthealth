using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class Genero : IEntity<Guid>
{
    public Genero(string identificacao)
    {
        Identificacao = identificacao;
    }

    public Genero() { }

    public Guid Id { get; set; } = default!;

    public string Identificacao { get; private set; } = default!;
}
