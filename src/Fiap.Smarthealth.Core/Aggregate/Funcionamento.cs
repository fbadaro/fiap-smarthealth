namespace Fiap.Smarthealth.Core.Aggregate;

public class Funcionamento
{
    public Funcionamento(DateTime abertura, DateTime encerramento)
    {
        Abertura = abertura;
        Encerramento = encerramento;
    }

    public Funcionamento() { }

    public DateTime Abertura { get; private set; } = default!;

    public DateTime Encerramento { get; private set; } = default!;
}
