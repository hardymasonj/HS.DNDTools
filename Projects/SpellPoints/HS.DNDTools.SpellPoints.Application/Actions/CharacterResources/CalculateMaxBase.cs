using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources
{
    public abstract class CalculateMaxBase
    {
        public abstract int GetMax(ICharacter character);
    }
}
