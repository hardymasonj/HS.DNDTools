using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources;
using HS.DNDTools.SpellPoints.Application.Models;
using HS.DNDTools.SpellPoints.Application.Models.DnD5e;
using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.LevelBasedResource
{
    public class Tests
    {
        [Theory]
        [InlineData("Sorcerer", 5)]
        [InlineData("Ranger", 5)]
        [InlineData("Fighter", 5)]
        [InlineData("Wizard", 0)]
        public void TestMulticlass(string className, int expected)
        {
            var character = new CharacterModel()
            {
                Name = "Ted Mosby",
                Id = "1"
            };
            character.ClassLevels = new List<IClassLevel>(new[]
            {
                new DnD5eClassLevelModel()
                {
                    Name = "Sorcerer",
                    Level = 5,
                    Subclass = "Aberrant Mind"
                },
                new DnD5eClassLevelModel()
                {
                    Name = "Ranger",
                    Subclass = "Drakewarden",
                    Level = 5
                },
                new DnD5eClassLevelModel()
                {
                    Name = "Fighter",
                    Subclass = "Battlemaster",
                    Level = 5
                }
            });
            var calculator = new CalculateMaxLevelClassFeature(className);
            Assert.Equal(expected, calculator.GetMax(character));
        }
    }
}
