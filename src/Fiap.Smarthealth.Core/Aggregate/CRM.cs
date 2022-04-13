namespace Fiap.Smarthealth.Core.Aggregate
{
    public class CRM
    {
        public CRM(string numero, string uF)
        {
            Numero = numero;
            UF = uF;
        }

        public string Numero { get; private set; }

        public string UF { get; private set; }
    }
}
