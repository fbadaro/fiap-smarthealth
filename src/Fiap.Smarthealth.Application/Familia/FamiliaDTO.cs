using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Smarthealth.Application.Familia;

public class FamiliaDTO : EntityDTO
{
    public string Sobrenome { get; set; } = default!;    

    public string Telefone { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string CNS { get; set; } = default!;

    public string Logradouro { get; set; } = default!;

    public string Complemento { get; set; } = default!;

    public string Bairro { get; set; } = default!;

    public string CEP { get; set; } = default!;
}
