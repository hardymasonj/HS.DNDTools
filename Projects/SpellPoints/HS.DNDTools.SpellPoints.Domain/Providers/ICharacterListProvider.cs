using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Providers
{
    public interface ICharacterListProvider
    {
        IEnumerable<ICharacter> GetCharacters();
        Task<IEnumerable<ICharacter>> GetCharactersAsync();
    }
}
