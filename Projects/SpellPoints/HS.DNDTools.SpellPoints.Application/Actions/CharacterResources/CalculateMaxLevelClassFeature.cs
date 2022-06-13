using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources
{
    public class CalculateMaxLevelClassFeature : CalculateMaxBase
    {
        private string _className = string.Empty;
        public CalculateMaxLevelClassFeature(string className)
        {
            this._className = className;
        }
        public override int GetMax(ICharacter character)
        {
            return character.ClassLevels?.Where(l => l.Name == _className).Sum(l => l.Level) ?? 0;
        }
    }
}
