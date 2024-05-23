using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapiens.Shared.Enums
{
    public enum Titulacao
    {
        [Description("Titulação")]
        Graduacao,
        Especializacao,
        Mestrado,
        Doutorado,
        PhD
    }
}
