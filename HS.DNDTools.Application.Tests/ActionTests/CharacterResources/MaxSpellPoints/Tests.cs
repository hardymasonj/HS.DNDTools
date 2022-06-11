using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources;
using HS.DNDTools.SpellPoints.Application.Models;
using HS.DNDTools.SpellPoints.Domain.Characters;
using System.Collections.Generic;
using Xunit;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.MaxSpellPoints
{
    public class Tests
    {
        [Theory]
        [InlineData("Paladin", "", 2, 4)]
        [InlineData("Wizard", "", 1, 4)]
        [InlineData("Rogue", "Arcane Trickster", 3, 4)]
        [InlineData("Paladin", "", 1, 0)]
        [InlineData("Rogue", "", 3, 0)]
        public void SingleClassTests(string className, string sublcass, int level, int expected)
        {
            var config = new TestConfiguration();
            var character = new CharacterModel();
            var classLevels = new List<IClassLevel>();
            var calculator = new CalculateMaxSpellPoints(config.SpellPointsByLevel);

            classLevels.Add(new ClassLevelTestModel() { Name = className, Subclass = sublcass, Level = level });
            character.ClassLevels = classLevels;

            var maxPoints = calculator.GetMax(character);
            Assert.Equal(expected, maxPoints);
        }
    }
}