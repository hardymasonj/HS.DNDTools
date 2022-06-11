using HS.DNDTools.SpellPoints.Domain.Characters;

namespace HS.DNDTools.SpellPoints.Application.Models
{
    public class CharacterModel : ICharacter
    {
        public CharacterModel()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int CurrentSpellPoints { get; set; }
        public int MaxSpellPoints { get; set; }
        public string Id { get; set; }
        public IEnumerable<IClassLevel> ClassLevels { get; set; }
    }
}