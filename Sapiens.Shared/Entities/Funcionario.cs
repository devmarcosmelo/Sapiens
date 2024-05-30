using Sapiens.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Entities;

public class Funcionario : Pessoa 
{
    
    public decimal? Salario { get; set; }
    public SituacaoFuncionario? Situacao { get; set; }

    public string? Funcao { get; set; }


}
