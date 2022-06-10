using HS.DNDTools.SpellPoints.Domain.Characters;

namespace HS.DNDTools.SpellPoints.WebApp.Models
{
    public class CharacterModel : ICharacter
    {
        public string Name { get; set; }

        public int CurrentSpellPoints { get; set; }

        public int MaxSpellPoints { get; set; }

        public int Level { get; set; }

        public string Id { get; set; }
    }
}
