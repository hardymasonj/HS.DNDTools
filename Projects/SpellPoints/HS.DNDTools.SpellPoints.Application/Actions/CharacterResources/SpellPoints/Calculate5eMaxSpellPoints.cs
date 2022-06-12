using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints
{
    public class Calculate5eMaxSpellPoints : CalculateMaxSpellPointsBase
    {
        public Calculate5eMaxSpellPoints(IReadOnlyDictionary<int, int> pointsByLevel) : base(pointsByLevel)
        {
        }

        protected override int GetLevel(ICharacter character)
        {
            double casterLevel = 0;
            foreach (var classLevel in character.ClassLevels)
            {
                //Need to calculate w/ decimal point.
                casterLevel += (double)classLevel.Level / (int)classLevel.CasterType; //TODO - Need to test a 1/3rd caster @ levels 3 and 6, results should be "GetLevel" == 1 and "GetLevel" == 2 respectively
            }
            return (int)Math.Floor(casterLevel); //round the level down.
        }
    }
}
