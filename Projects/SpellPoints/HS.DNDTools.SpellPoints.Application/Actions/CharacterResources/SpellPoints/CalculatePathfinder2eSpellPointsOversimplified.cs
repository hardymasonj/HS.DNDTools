using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints
{
    public class CalculatePathfinder2eSpellPointsOversimplified : CalculateMaxSpellPointsBase
    {
        public CalculatePathfinder2eSpellPointsOversimplified(IReadOnlyDictionary<int, int> pointsByLevel) : base(pointsByLevel)
        {

        }

        protected override int GetLevel(ICharacter character)
        {
            return character.Level; //I don't think Pathfinder 2e does multi-classing. Though Feats may be relevant, I'm not as familiar with the rules at this time. Should still demonstrate proof of concept.
        }
    }
}
