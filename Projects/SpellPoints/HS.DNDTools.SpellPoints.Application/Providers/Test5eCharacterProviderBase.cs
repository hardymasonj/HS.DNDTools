using HS.DNDTools.SpellPoints.Application.Actions.CharacterResources.SpellPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Providers
{
    public abstract class Test5eCharacterProviderBase
    {
        protected IReadOnlyDictionary<int, int> SpellPointLevels { get; init; }
        protected Calculate5eMaxSpellPoints SpellPointCalcluator { get; init; }
        public Test5eCharacterProviderBase()
        {
            SpellPointLevels = new Dictionary<int, int>(new[]
            {
                KeyValuePair.Create(1, 4),
                KeyValuePair.Create(2, 6),
                KeyValuePair.Create(3, 14),
                KeyValuePair.Create(4, 17),
                KeyValuePair.Create(5, 27),
                KeyValuePair.Create(6, 32),
                KeyValuePair.Create(7, 38),
                KeyValuePair.Create(8, 44),
                KeyValuePair.Create(9, 57),
                KeyValuePair.Create(10, 64),
                KeyValuePair.Create(11, 73),
                KeyValuePair.Create(12, 73),
                KeyValuePair.Create(13, 83),
                KeyValuePair.Create(14, 83),
                KeyValuePair.Create(15, 94),
                KeyValuePair.Create(16, 94),
                KeyValuePair.Create(17, 107),
                KeyValuePair.Create(18, 114),
                KeyValuePair.Create(19, 123),
                KeyValuePair.Create(20, 133)
            });
            SpellPointCalcluator = new Calculate5eMaxSpellPoints(SpellPointLevels);
        }
    }
}
