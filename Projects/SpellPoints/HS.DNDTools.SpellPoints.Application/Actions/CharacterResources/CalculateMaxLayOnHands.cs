using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources
{
    //This is an approach to handle feature calculation where each feature gets its own class
    public class CalculateMaxLayOnHands : CalculateMaxBase
    {
        public override int GetMax(ICharacter character)
        {
            int paladinLevels = character.ClassLevels.Where(l => l.Name == "Paladin")?.Sum(l => l.Level) ?? 0;
            return paladinLevels * 5;
        }
    }
}
