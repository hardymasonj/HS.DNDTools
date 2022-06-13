using HS.DNDTools.SpellPoints.Domain.Characters;

namespace HS.DNDTools.SpellPoints.Application.Models
{
    public class CharacterModel : ICharacter
    {
        public CharacterModel()
        {
            this.Attributes = new Dictionary<string, int>(new KeyValuePair<string, int>[]
            {
                KeyValuePair.Create("Dexterity", 0),
                KeyValuePair.Create("Strength", 0),
                KeyValuePair.Create("Constitution", 0),
                KeyValuePair.Create("Intelligence", 0),
                KeyValuePair.Create("Wisdom", 0),
                KeyValuePair.Create("Charisma", 0)
            });
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int CurrentSpellPoints { get; set; }
        public int MaxSpellPoints { get; set; }
        public string Id { get; set; }
        public IEnumerable<IClassLevel> ClassLevels { get; set; }
        public IReadOnlyDictionary<string, int> Attributes { get; init; }
    }
}