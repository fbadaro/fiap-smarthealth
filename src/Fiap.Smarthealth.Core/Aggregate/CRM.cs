namespace Fiap.Smarthealth.Core.Aggregate;

public class CRM
{
    public CRM(string numero, string uF)
    {
        Numero = numero;
        UF = uF;
    }

    public CRM() { }

    public string Numero { get; private set; } = default!;

    public string UF { get; private set; } = default!;
}
