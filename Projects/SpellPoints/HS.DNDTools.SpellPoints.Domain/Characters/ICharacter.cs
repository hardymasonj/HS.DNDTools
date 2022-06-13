using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Characters
{
    public interface ICharacter
    {
        string Id { get; }
        string Name { get; }
        int CurrentSpellPoints { get; }
        int MaxSpellPoints { get; }
        int Level { get; }
        IReadOnlyDictionary<string, int> Attributes { get; }
        IEnumerable<IClassLevel> ClassLevels { get; } //TODO - This should actually be IReadOnlyDictionary<string, IClassLevel> where the string is the class name. I am unaware of an TTRPG systems now that allow "multiclassing" within the same class, bare minimum developing towards D&D 5e and Pathfinder v1 and v2 covers the very large majority of the market space. The IReadOnlyDictionary would allow for better efficiency when calculating resources specific to a single class
    }
}
