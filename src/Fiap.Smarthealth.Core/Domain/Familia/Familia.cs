using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain
{
    public class Familia : Entity<Guid>
    {
        public Familia(string sobrenome, string cNS, Endereco endereco, string telefone, string email)
        {
            Sobrenome = sobrenome;
            CNS = cNS;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        public string Sobrenome { get; private set; }

        public string CNS { get; private set; }

        public Endereco Endereco { get; private set; }

        public string Telefone { get; private set; }

        public string Email { get; private set; }
    }
}
