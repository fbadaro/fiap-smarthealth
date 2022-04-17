namespace Fiap.Smarthealth.Application.Familia;

public class FamiliaDTO : EntityDTO
{
    public string Sobrenome { get; set; } = default!;    

    public string Telefone { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string CNSNumero { get; set; } = default!;

    public string EnderecoLogradouro { get; set; } = default!;

    public string EnderecoComplemento { get; set; } = default!;

    public string EnderecoBairro { get; set; } = default!;

    public string EnderecoCEP { get; set; } = default!;
}
