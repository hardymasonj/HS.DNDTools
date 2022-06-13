using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints;
using HS.DNDTools.SpellPoints.Application.Models;
using HS.DNDTools.SpellPoints.Application.Models.DnD5e;
using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Providers
{
    public class Test5eCharacterProvider : Test5eCharacterProviderBase, ICharacterProvider
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
            switch (id)
            {
                case "1":
                    character.Name = "Patrick O'Neil";
                    character.Level = 5;
                    character.ClassLevels = new List<IClassLevel>(new[]
                    {
                        new DnD5eClassLevelModel()
                        {
                            Name = "Bard",
                            Level = 5,
                            Subclass = "College of Eloquence"
                        }
                    });
                    break;
                case "2":
                    character.Name = "Hylaeus";
                    character.Level = 10;
                    character.ClassLevels = new List<IClassLevel>(new[]
                    {
                        new DnD5eClassLevelModel()
                        {
                            Name = "Bard",
                            Level = 10,
                            Subclass = "College of Creation"
                        }
                    });
                    break;
                case "3":
                    character.Name = "Merlyn";
                    character.Level = 20;
                    character.ClassLevels = new List<IClassLevel>(new[]
                    {
                        new DnD5eClassLevelModel()
                        {
                            Name = "Sorcerer",
                            Level = 20,
                            Subclass = "Draconic Bloodline"
                        }
                    });
                    break;
            }
            character.MaxSpellPoints = this.SpellPointCalcluator.GetMax(character);
            character.CurrentSpellPoints = character.MaxSpellPoints;
            return character;
        }

        public ICharacter GetCharacterAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
