using HS.DNDTools.SpellPoints.Application.Actions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS.DNDTools.Application.Tests.ActionTests
{
    public class AttributeModifierTests
    {
        /// <summary>
        /// Verifies calclulation of positive values is correct
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedModifier"></param>
        [Theory]
        [InlineData(10, 0)]
        [InlineData(11, 0)]
        [InlineData(12, 1)]
        [InlineData(13, 1)]
        [InlineData(14, 2)]
        [InlineData(15, 2)]
        [InlineData(16, 3)]
        [InlineData(17, 3)]
        [InlineData(18, 4)]
        [InlineData(19, 4)]
        [InlineData(20, 5)]
        [InlineData(21, 5)]
        [InlineData(22, 6)]
        [InlineData(23, 6)]
        [InlineData(24, 7)]
        public void PositiveValues(int value, int expectedModifier)
        {
            var calcluator = new CalculateAttributeModifier();
            var actualModifier = calcluator.GetModifier(value);
            Assert.Equal(expectedModifier, actualModifier);
        }
        /// <summary>
        /// Verifies calcluations of negative modifiers are correct
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedModifier"></param>
        [Theory]
        [InlineData(9, -1)]
        [InlineData(8, -1)]
        [InlineData(7, -2)]
        [InlineData(6, -2)]
        [InlineData(5, -3)]
        [InlineData(4, -3)]
        [InlineData(3, -4)]
        [InlineData(2, -4)]
        [InlineData(1, -5)]
        public void NegativeValues(int value, int expectedModifier)
        {
            var calcluator = new CalculateAttributeModifier();
            var actualModifier = calcluator.GetModifier(value);
            Assert.Equal(expectedModifier, actualModifier);
        }

        /// <summary>
        /// Verifies an exception is thrown if the value is less than 0
        /// </summary>
        [Fact]
        public void GuardClauseTest()
        {
            bool threwException;
            try
            {
                var calcluator = new CalculateAttributeModifier();
                var actualModifier = calcluator.GetModifier(-1);
                threwException = true;
            }
            catch(ArgumentException)
            {
                threwException = true;
            }
            Assert.True(threwException);
        }
    }
}
