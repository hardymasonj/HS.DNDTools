using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.Attributes
{
    public class CalculateAttributeModifier
    {
        public virtual int GetModifier(int value)
        {
            if (value < 0) throw new ArgumentException("Value must be zero or greater.");

            if (value >= 10) return (value - 10) / 2;
            return (int)Math.Round((decimal)(value - 10) / 2, 0, MidpointRounding.AwayFromZero);
        }
    }
}
