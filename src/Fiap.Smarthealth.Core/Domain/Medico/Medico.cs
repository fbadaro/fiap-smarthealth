using Fiap.Smarthealth.Core.Aggregate;
using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain
{
    public class Medico : Entity<Guid>
    {
        public Medico(string nome, CPF cPF, CNPJ cNPJ, CRM cRM, string telefone, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            CNPJ = cNPJ;
            CRM = cRM;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }

        public CPF CPF { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public CRM CRM { get; private set; }

        public string Telefone { get; private set; }

        public DateTime DataNascimento { get; private set; }
    }
}
