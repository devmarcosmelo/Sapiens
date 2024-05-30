using Sapiens.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Entities;

public class Aluno: Pessoa
{
    
    public string? Matricula { get; set; }

    public SituacaoAluno? Situacao { get; set; }
    public Curso? Curso { get; set; }

}
