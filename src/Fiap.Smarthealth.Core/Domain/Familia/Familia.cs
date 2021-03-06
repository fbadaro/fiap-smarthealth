using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain;

public class Familia : Entity
{
    public Familia(string sobrenome, CNS cNS, Endereco endereco, string telefone, string email)
    {
        Sobrenome = sobrenome;
        CNS = cNS;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
    }

    public Familia() { }    

    public string Sobrenome { get; private set; } = default!;

    public CNS CNS { get; private set; } = default!;

    public Endereco Endereco { get; private set; } = default!;

    public string Telefone { get; private set; } = default!;

    public string Email { get; private set; } = default!;
}
