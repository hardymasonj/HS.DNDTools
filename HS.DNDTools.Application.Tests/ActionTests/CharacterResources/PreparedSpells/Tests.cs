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

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.PreparedSpells
{
    public class Tests
    {
        [Theory(Skip = "Attributes need to be implemented in this test before it will run properly")]
        [InlineData("Wizard", 4, 14, 6)]
        [InlineData("Sorcerer", 4, 14, 6)]
        public void SingleClassTests(string className, int level, int attributeValue, int expected)
        {
            var calculator = CalculateMaxSpellsPrepared.GetCalculator(className);
            var character = new CharacterModel()
            {
                ClassLevels = new List<IClassLevel>(new[] { new DnD5eClassLevelModel()
                    {
                        Level = level,
                        Name = className
                    }
                })
            };
            var actual = calculator.GetMax(character);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NullTest()
        {
            var calculator = CalculateMaxSpellsPrepared.GetCalculator("Fighter");
            Assert.Null(calculator);
        }
    }
}
