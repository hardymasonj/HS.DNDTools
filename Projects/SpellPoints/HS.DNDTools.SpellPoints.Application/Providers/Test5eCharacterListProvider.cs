using HS.DNDTools.SpellPoints.Application.Models;
using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Providers;
using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints;
using HS.DNDTools.SpellPoints.Application.Models.DnD5e;

namespace HS.DNDTools.SpellPoints.Application.Providers
{
    public class Test5eCharacterListProvider : Test5eCharacterProviderBase, ICharacterListProvider
    {
        public IEnumerable<ICharacter> GetCharacters()
        {
            var characters = new List<ICharacter>();
            var character = new CharacterModel() { Name = "Patrick O'Neil", Id = "1" };

            character.ClassLevels = new List<IClassLevel>(new[]
            {
                new DnD5eClassLevelModel()
                {
                    Name = "Bard",
                    Subclass = "College of Eloquence",
                    Level = 5
                }
            });
            character.MaxSpellPoints = SpellPointCalcluator.GetMax(character);
            character.CurrentSpellPoints = character.MaxSpellPoints;
            characters.Add(character);

            character = new CharacterModel() { Name = "Hylaeus", Id = "2" };
            character.ClassLevels = new List<IClassLevel>(new[]
            {
                new DnD5eClassLevelModel()
                {
                    Name = "Bard",
                    Subclass = "College of Creation",
                    Level = 10
                }
            });
            character.MaxSpellPoints = SpellPointCalcluator.GetMax(character);
            character.CurrentSpellPoints = character.MaxSpellPoints;
            characters.Add(character);

            character = new CharacterModel() { Name = "Merlyn", Id = "3" };
            character.ClassLevels = new List<IClassLevel>(new[]
            {
                new DnD5eClassLevelModel()
                {
                    Name = "Sorcerer",
                    Subclass = "Draconic Bloodline",
                    Level = 20
                }
            });
            character.MaxSpellPoints = SpellPointCalcluator.GetMax(character);
            character.CurrentSpellPoints = character.MaxSpellPoints;
            characters.Add(character);

            return characters;
        }

        public Task<IEnumerable<ICharacter>> GetCharactersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
