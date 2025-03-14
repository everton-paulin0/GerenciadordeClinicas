using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadordeClinicas.Core.Entities.Enum
{
    public enum TypeBloodEnum
    {
        [Description("A +")]
        APositivo,
        [Description("A -")]
        Anegativo,
        [Description("B +")]
        BPositivo,
        [Description("B -")]
        BNegativo,
        [Description("AB +")]
        ABPositivo,
        [Description("AB -")]
        ABnegativo,
        [Description("O +")]
        OPositivo,
        [Description("O -")]
        Onegativo
    }
}
