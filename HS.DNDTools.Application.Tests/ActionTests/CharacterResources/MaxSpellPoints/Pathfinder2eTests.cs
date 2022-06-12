using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints;
using HS.DNDTools.SpellPoints.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.MaxSpellPoints
{
    public class Pathfinder2eTests
    {
        [Theory]
        [InlineData(1, 4)]
        [InlineData(2, 6)]
        [InlineData(3, 12)]
        public void WizardTest(int level, int expected)
        {
            var configuration = new Pathfinder2eTestConfiguration("Wizard");
            var character = new CharacterModel()
            {
                Level = level
            };
            var calculator = new CalculatePathfinder2eSpellPointsOversimplified(configuration.SpellPointsByLevel);
            Assert.Equal(expected, calculator.GetMax(character));
        }

        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 8)]
        [InlineData(3, 17)]
        public void SorcererTest(int level, int expected)
        {
            var configuration = new Pathfinder2eTestConfiguration("Sorcerer");
            var character = new CharacterModel()
            {
                Level = level
            };
            var calculator = new CalculatePathfinder2eSpellPointsOversimplified(configuration.SpellPointsByLevel);
            Assert.Equal(expected, calculator.GetMax(character));
        }
    }
}
