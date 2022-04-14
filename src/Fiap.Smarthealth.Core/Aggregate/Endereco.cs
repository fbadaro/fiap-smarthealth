namespace Fiap.Smarthealth.Core.Aggregate
{
    public class Endereco
    {
        public Endereco(string logradouro, string complemento, string bairro, string cEP)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cEP;            
        }

        public string Logradouro { get; private set; }

        public string Complemento { get; private set; }

        public string Bairro { get; private set; }

        public string CEP { get; private set; }         
    }
}
