namespace Fiap.Smarthealth.Core.Aggregate
{
    public class RG
    {
        public RG(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; private set; }

        private bool IsValid() => true;
    }
}
