namespace Fiap.Smarthealth.Core.Aggregate
{
    public class Funcionamento
    {
        public Funcionamento(DateTime abertura, DateTime encerramento)
        {
            Abertura = abertura;
            Encerramento = encerramento;
        }

        public DateTime Abertura { get; private set; }

        public DateTime Encerramento { get; private set; }
    }
}
