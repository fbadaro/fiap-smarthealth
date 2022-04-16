using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class MedicoEspecialidade : IEntity<Guid>
{
    public MedicoEspecialidade(string especialidade)
    {
        Especialidade = especialidade;
    }

    public MedicoEspecialidade() { }

    public Guid Id { get; set; }

    public string Especialidade { get; private set; }
}
