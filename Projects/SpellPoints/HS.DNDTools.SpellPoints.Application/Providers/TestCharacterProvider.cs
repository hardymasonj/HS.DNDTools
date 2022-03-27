using HS.DNDTools.SpellPoints.Application.Actions;
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
    public class TestCharacterProvider : ICharacterProvider
    {
        public ICharacter CreateCharacter(string name, int level)
        {
            throw new NotImplementedException();
        }

        public ICharacter CreateCharacterAsync(string name, int level)
        {
            throw new NotImplementedException();
        }

        public ICharacter GetCharacter(string id)
        {
            CharacterModel character = new CharacterModel { Id = id };
            MaxSpellPoints maxSPCalculator = new MaxSpellPoints();
            switch (id)
            {
                case "1":
                    character.Name = "Patrick O'Neil";
                    character.Level = 5;
                    break;
                case "2":
                    character.Name = "Hylaeus";
                    character.Level = 10;
                    break;
            }
            character.MaxSpellPoints = maxSPCalculator.CalculateForLevel(character.Level);
            character.CurrentSpellPoints = character.MaxSpellPoints;
            return character;
        }

        public ICharacter GetCharacterAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
