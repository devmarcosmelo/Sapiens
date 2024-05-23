using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Enums
{
    public enum EstadoCivil
    {
        [Description("Solteiro")]
        Solteiro,

        [Description("União Estável")]
        UniaoEstavel,

        [Description("Casado")]
        Casado,

        [Description("Divorciado")]
        Divorciado,

        [Description("Viúvo")]
        Viuvo
    }
}
