using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.MaxSpellPoints
{
    internal class TestConfiguration
    {
        internal IReadOnlyDictionary<int, int> SpellPointsByLevel { get; }
        internal TestConfiguration()
        {
            var spellPointsByLevel = new Dictionary<int, int>();
            spellPointsByLevel.Add(0, 0);
            spellPointsByLevel.Add(1, 4);
            spellPointsByLevel.Add(2, 6);
            spellPointsByLevel.Add(3, 14);
            spellPointsByLevel.Add(4, 17);
            spellPointsByLevel.Add(5, 27);
            spellPointsByLevel.Add(6, 32);
            spellPointsByLevel.Add(7, 38);
            spellPointsByLevel.Add(8, 44);
            spellPointsByLevel.Add(9, 57);
            spellPointsByLevel.Add(10, 64);
            spellPointsByLevel.Add(11, 73);
            spellPointsByLevel.Add(12, 73);
            spellPointsByLevel.Add(13, 83);
            spellPointsByLevel.Add(14, 83);
            spellPointsByLevel.Add(15, 94);
            spellPointsByLevel.Add(16, 94);
            spellPointsByLevel.Add(17, 107);
            spellPointsByLevel.Add(18, 114);
            spellPointsByLevel.Add(19, 123);
            spellPointsByLevel.Add(20, 133);
            this.SpellPointsByLevel =  spellPointsByLevel;
        }
    }
}
