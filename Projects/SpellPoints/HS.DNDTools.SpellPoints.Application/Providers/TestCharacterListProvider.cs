using HS.DNDTools.SpellPoints.Application.Models;
using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Providers
{
    public class TestCharacterListProvider : ICharacterListProvider
    {
        public IEnumerable<ICharacter> GetCharacters()
        {
            var characters = new List<ICharacter>();
            var calculator = new Actions.MaxSpellPoints();
            var character = new CharacterModel() { Name = "Patrick O'Neil", Level = 5 };
            character.Id = "1";
            character.CurrentSpellPoints = calculator.CalculateForLevel(character.Level);
            character.MaxSpellPoints = character.CurrentSpellPoints;
            characters.Add(character);

            character = new CharacterModel() { Name = "Hylaeus", Level = 10 };
            character.CurrentSpellPoints = calculator.CalculateForLevel(character.Level);
            character.MaxSpellPoints = character.CurrentSpellPoints;
            character.Id = "2";
            characters.Add(character);

            character = new CharacterModel() { Name = "Merlyn", Level = 20 };
            character.CurrentSpellPoints = calculator.CalculateForLevel(character.Level);
            character.MaxSpellPoints = character.CurrentSpellPoints;
            character.Id = "3";
            characters.Add(character);

            return characters;
        }

        public Task<IEnumerable<ICharacter>> GetCharactersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
