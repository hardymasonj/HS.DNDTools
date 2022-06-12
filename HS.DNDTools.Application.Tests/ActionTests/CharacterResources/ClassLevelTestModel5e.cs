using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Enums.ClassEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources
{
    internal class ClassLevelTestModel5e : IClassLevel
    {
        public string Name { get; set; } = string.Empty;
        public string Subclass { get; set; } = string.Empty;
        public int Level { get; set; }
        public CasterType CasterType
        {
            get
            {
                switch (Name)
                {
                    case "Paladin":
                    case "Ranger":
                    case "Artificer":
                        return CasterType.Half;

                    case "Wizard":
                    case "Bard":
                    case "Sorcerer":
                    case "Cleric":
                    case "Druid":
                        return CasterType.Full;

                    case "Fighter":
                        if(this.Subclass == "Eldritch Knight")
                        {
                            return CasterType.Third;
                        }
                        return CasterType.None;

                    case "Rogue":
                        if (this.Subclass == "Arcane Trickster") return CasterType.Third;
                        return CasterType.None;
                    default:
                        return CasterType.None;
                }
            }
        }
        public string CastingAttribute
        {
            get
            {
                switch (Name)
                {
                    case "Wizard":
                    case "Artificer":
                        return "Intelligence";
                    case "Cleric":
                    case "Druid":
                    case "Ranger":
                        return "Wisdom";
                    case "Paladin":
                    case "Bard":
                    case "Sorcerer":
                        return "Charisma";
                    case "Fighter":
                        if (this.Subclass == "Eldritch Knight") return "Intelligence";
                        return string.Empty;
                    case "Rogue":
                        if (this.Subclass == "Arcane Trickster") return "Intelligence";
                        return string.Empty;
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
