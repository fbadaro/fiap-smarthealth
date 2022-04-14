﻿using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class MedicoEspecialidade : Entity<Guid>
{
    public MedicoEspecialidade(string especialidade)
    {
        Especialidade = especialidade;
    }

    public MedicoEspecialidade() { }

    public string Especialidade { get; private set; }
}
