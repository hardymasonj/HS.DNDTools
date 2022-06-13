using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Enums.ClassEnums
{
    public enum CasterType
    {
        Full = 1,
        Half = 2,
        Third = 3,
        None = int.MaxValue //cheat method: dividing by max value and rounding down will always result in zero
    }
}
