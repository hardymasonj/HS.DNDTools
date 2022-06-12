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
            double casterLevel = 0;
            foreach(var classLevel in character.ClassLevels)
            {
                casterLevel += (double)classLevel.Level / (int)classLevel.CasterType;
            }
            int roundedLevel = (int)Math.Floor(casterLevel);
            if (!_pointsByLevel.ContainsKey(roundedLevel)) throw new KeyNotFoundException($"Spell level data not available for level {roundedLevel}");
            return _pointsByLevel[roundedLevel];
        }
    }
}
