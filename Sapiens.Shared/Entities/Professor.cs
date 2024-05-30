using Sapiens.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Entities
{
    public class Professor : Funcionario
    {
        public Titulacao? Titulacao { get; set; }
        //public string? Cpf { get; set; }
        public string? Formacao { get; set; }

        public Disciplina? Disciplina { get; set; }
    }
}
