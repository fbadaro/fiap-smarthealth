namespace Fiap.Smarthealth.Core.Aggregate
{    
    public class CNPJ
    {
        public CNPJ(string numero, string emissor)
        {
            Numero = numero;
            Emissor = emissor;
        }

        public string Numero { get; private set; }

        public string Emissor { get; private set; }

        private bool IsValid() => true;
    }
}
