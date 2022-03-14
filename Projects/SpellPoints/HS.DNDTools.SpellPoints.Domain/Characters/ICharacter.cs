using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Characters
{
    public interface ICharacter
    {
        string Name { get; }
        int CurrentSpellPoints { get; }
        int MaxSpellPoints { get; }
        int Level { get; }
    }
}
