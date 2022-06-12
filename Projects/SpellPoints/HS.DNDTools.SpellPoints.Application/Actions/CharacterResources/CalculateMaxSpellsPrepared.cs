using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions.CharacterResources
{
    public class CalculateMaxSpellsPrepared : CalculateMaxBase
    {
        private string ClassName { get; init; }
        /// <summary>
        /// Classes that prepare spells daily in a ReadOnly Set
        /// </summary>
        private static IReadOnlySet<string> _preparedSpellClasses = new HashSet<string>(new string[] { "Druid", "Wizard", "Cleric", "Artificer", "Paladin" }); 
        //Marked as static because it is an unchanging resource that can be shared without being recreated
        public static CalculateMaxSpellsPrepared GetCalculator(string className)
        {
            if (_preparedSpellClasses.Contains(className)) return new CalculateMaxSpellsPrepared(className);
            return null;
        }
        private CalculateMaxSpellsPrepared(string className)
        {
            ClassName = className;
        }
        public override int GetMax(ICharacter character)
        {
            var classLevel = character.ClassLevels.FirstOrDefault(l => l.Name == this.ClassName);
            if (classLevel is null) return 0;
            var calculatedLevel = classLevel.Level / (int)classLevel.CasterType;
            return calculatedLevel + character.Attributes.GetValueOrDefault(classLevel.CastingAttribute);
        }
    }
}
