namespace Fiap.Smarthealth.Core.Aggregate
{
    public class CPF
    {
        public CPF(string numero, string emissor, string uF)
        {
            Numero = numero;
            Emissor = emissor;
            UF = uF;
        }

        public string Numero { get; set; }

        public string Emissor { get; set; }

        public string UF { get; set; }

        private bool IsValid() => true;
    }
}
