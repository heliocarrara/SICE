using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICE.Models.Enumerators
{
    public enum TipoLogin
    {
        [Description("Visita")]
        Visita = 1,

        [Description("Administrador")]
        Administrador = 2,

        [Description("Conselheiro")]
        Conselheiro = 3,

        [Description("Morador")]
        Morador = 4,

        [Description("Prae")]
        Prae = 5,

        [Description("Segurança")]
        Seguranca = 6,
    }
}
