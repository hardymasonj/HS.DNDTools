using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources
{
    public class CalculateMaxSpellPoints : CalculateMaxBase
    {
        private readonly IReadOnlyDictionary<int, int> _pointsByLevel = null;
        public CalculateMaxSpellPoints(IReadOnlyDictionary<int, int> pointsByLevel)
        {
            if (pointsByLevel is null) throw new ArgumentNullException(nameof(pointsByLevel));
            _pointsByLevel = pointsByLevel;
        }
        public override int GetMax(ICharacter character)
        {
            int casterLevel = 0;
            foreach(var classLevel in character.ClassLevels)
            {
                casterLevel += classLevel.Level / (int)classLevel.CasterType;
            }
            if (!_pointsByLevel.ContainsKey(casterLevel)) throw new KeyNotFoundException($"Spell level data not available for level {casterLevel}");
            return _pointsByLevel[casterLevel];
        }
    }
}
