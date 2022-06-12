using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints
{
    public abstract class CalculateMaxSpellPointsBase : CalculateMaxBase
    {
        protected IReadOnlyDictionary<int, int> PointsByLevel { get; private init; }
        public CalculateMaxSpellPointsBase(IReadOnlyDictionary<int, int> pointsByLevel)
        {
            if (pointsByLevel is null) throw new ArgumentNullException(nameof(pointsByLevel));
            this.PointsByLevel = pointsByLevel;
        }

        protected abstract int GetLevel(ICharacter character);

        public override int GetMax(ICharacter character)
        {
            return this.PointsByLevel.GetValueOrDefault(this.GetLevel(character));
        }
    }
}
