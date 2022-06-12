using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources;
using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints;
using HS.DNDTools.SpellPoints.Application.Models;
using HS.DNDTools.SpellPoints.Domain.Characters;
using System.Collections.Generic;
using Xunit;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.MaxSpellPoints
{
    public class DND5eTests
    {
        [Theory]
        [InlineData("Paladin", "", 2, 4)]
        [InlineData("Wizard", "", 1, 4)]
        [InlineData("Rogue", "Arcane Trickster", 3, 4)]
        [InlineData("Paladin", "", 1, 0)]
        [InlineData("Rogue", "", 3, 0)]
        [InlineData("Rogue", "Arcane Trickster", 6, 6)]
        public void SingleClassTests(string className, string sublcass, int level, int expected)
        {
            var config = new DnD5eTestConfiguration();
            var character = new CharacterModel();
            var classLevels = new List<IClassLevel>();
            var calculator = new Calculate5eMaxSpellPoints(config.SpellPointsByLevel);

            classLevels.Add(new ClassLevelTestModel5e() { Name = className, Subclass = sublcass, Level = level });
            character.ClassLevels = classLevels;

            var maxPoints = calculator.GetMax(character);
            Assert.Equal(expected, maxPoints);
        }

        [Theory]
        [InlineData("Paladin", "", 2, "Wizard", "", 1, 6)] //HACK - This is not the ideal way to pass this data, just going for fast development for now.
        [InlineData("Sorcerer", "", 6, "Wizard", "", 2, 44)]
        [InlineData("Fighter", "", 5, "Wizard", "", 3, 14)]
        [InlineData("Fighter", "Eldritch Knight", 5, "Wizard", "", 3, 17)]
        [InlineData("Ranger", "", 3, "Paladin", "", 3, 14)]
        public void MultiClassTests(string className1, string subclass1, int class1Level, string className2, string subclass2, int class2Level, int expected)
        {
            var config = new DnD5eTestConfiguration();
            var character = new CharacterModel();
            var classLevels = new List<IClassLevel>();
            var calculator = new Calculate5eMaxSpellPoints(config.SpellPointsByLevel);

            classLevels.Add(new ClassLevelTestModel5e() { Name = className1, Subclass = subclass1, Level = class1Level });
            classLevels.Add(new ClassLevelTestModel5e() { Name = className2, Subclass = subclass2, Level = class2Level });
            character.ClassLevels = classLevels;

            var maxPoints = calculator.GetMax(character);
            Assert.Equal(expected, maxPoints);
        }
    }
}