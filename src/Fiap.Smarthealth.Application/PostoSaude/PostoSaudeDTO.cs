﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Smarthealth.Application.PostoSaude;

public class PostoSaudeDTO : EntityDTO
{
    public string Nome { get; set; }

    public string Telefone { get; set; }

    public string Email { get; set; }
}
