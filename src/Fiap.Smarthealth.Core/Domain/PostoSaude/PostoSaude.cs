using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain
{
    public class PostoSaude : Entity<Guid>
    {        
        public string Nome { get; private set; }

        public CNPJ CNPJ { get; private set; }        

        public Endereco Endereco { get; private set; }

        public string Telefone { get; private set; }

        public string Email { get; private set; }

        public Funcionamento Funcionamento { get; private set; }

        public PostoSaude(string nome, CNPJ cnpj, Endereco endereco, string telefone, string email, Funcionamento funcionamento)
        {
            Nome = nome;
            CNPJ = cnpj;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Funcionamento = funcionamento;
        }
    }
}
