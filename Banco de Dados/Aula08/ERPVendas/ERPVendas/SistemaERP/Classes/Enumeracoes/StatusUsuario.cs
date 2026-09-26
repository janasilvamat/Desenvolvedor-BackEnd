using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando Aprovação")]
        Aguardando,
        [Description("Aprovado")]
        Aprovado,
        [Description("Reprovado")]
        Reprovado
    }
}
