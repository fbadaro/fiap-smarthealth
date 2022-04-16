namespace Fiap.Smarthealth.Core.Aggregate;

public class CNPJ
{
    public CNPJ(string numero, string emissor)
    {
        Numero = numero;
        Emissor = emissor;
    }

    public CNPJ() { }

    public string Numero { get; private set; } = default!;

    public string Emissor { get; private set; } = default!;

    private bool IsValid() => true;
}
