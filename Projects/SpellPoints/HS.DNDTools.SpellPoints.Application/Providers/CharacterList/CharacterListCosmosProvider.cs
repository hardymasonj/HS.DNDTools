using HS.DNDTools.DataAccess.Providers;
using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Configuration;
using HS.DNDTools.SpellPoints.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Providers.CharacterList
{
    public class CharacterListCosmosProvider : CosmosProvider<ICharacter>, ICharacterProvider
    {
        public CharacterListCosmosProvider(ICosmosConfiguration config) : base("characters", config)
        {

        }

        public ICharacter CreateCharacter(string name, int level)
        {
            throw new NotImplementedException();
        }

        public ICharacter CreateCharacterAsync(string name, int level)
        {
            throw new NotImplementedException();
        }

        public ICharacter GetCharacter(string id)
        {
            throw new NotImplementedException();
        }

        public ICharacter GetCharacterAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
