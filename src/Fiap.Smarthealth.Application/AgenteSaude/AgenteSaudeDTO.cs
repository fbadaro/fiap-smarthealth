using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Smarthealth.Application.AgenteSaude;

public class AgenteSaudeDTO : EntityDTO
{
    public string Nome { get; set; } = default!;

    public string Telefone { get; set; } = default!;

    public DateTime DataNascimento { get; private set; } = default!;

    public string CNSNumero { get; set; } = default!;

    public string CPFNumero { get; set; } = default!;

    public string CPFEmissor { get; set; } = default!;

    public string CPFUF { get; set; } = default!;
}
