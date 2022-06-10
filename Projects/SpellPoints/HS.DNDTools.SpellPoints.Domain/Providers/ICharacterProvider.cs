using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Providers
{
    public interface ICharacterProvider
    {
        ICharacter GetCharacter(string id);
        ICharacter GetCharacterAsync(string id);
        ICharacter CreateCharacter(string name, int level);
        ICharacter CreateCharacterAsync(string name, int level);
    }
}
