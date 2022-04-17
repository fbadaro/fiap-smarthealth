namespace Fiap.Smarthealth.Application.PostoSaude;

public class PostoSaudeDTO : EntityDTO
{
    public string Nome { get; set; } = default!;

    public string Telefone { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string CNPJNumero { get; set; } = default!;

    public string CNPJEmissor { get; set; } = default!;

    public string EnderecoLogradouro { get; set; } = default!;

    public string EnderecoComplemento { get; set; } = default!;

    public string EnderecoBairro { get; set; } = default!;

    public string EnderecoCEP { get; set; } = default!;

    public string FuncionamentoAbertura { get; set; } = default!;

    public string FuncionamentoEncerramento { get; set; } = default!;
}
