using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources
{
    public class CalculateMaxMultipliedClassFeature : CalculateMaxBase
    {
        private string _className;
        private int _multiplier;
        public CalculateMaxMultipliedClassFeature(string className, int multiplier)
        {
            this._className = className;
            this._multiplier = multiplier;
        }
        public override int GetMax(ICharacter character)
        {
            var relevantLevels = character.ClassLevels?.Where(l => l.Name == _className)?.Sum(l => l.Level) ?? 0;
            return relevantLevels * _multiplier;
            throw new NotImplementedException();
        }
    }
}
