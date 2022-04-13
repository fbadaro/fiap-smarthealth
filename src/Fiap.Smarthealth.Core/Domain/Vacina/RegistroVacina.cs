using Fiap.Smarthealth.Core.Entities;

namespace Fiap.Smarthealth.Core.Domain
{
    public class RegistroVacina : Entity<Guid>
    {
        public RegistroVacina(string nome, DateTime dataAplicacao, DateTime? vencimento)
        {
            Nome = nome;
            DataAplicacao = dataAplicacao;
            Vencimento = vencimento;
        }

        public string Nome { get; private set; }

        public DateTime DataAplicacao { get; private set; }

        public DateTime? Vencimento { get; private set; } = null;
    }
}
