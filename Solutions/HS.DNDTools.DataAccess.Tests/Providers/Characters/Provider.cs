using HS.DNDTools.DataAccess.Providers;
using HS.DNDTools.SpellPoints.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.DataAccess.Tests.Providers.Characters
{
    internal class Provider : CosmosProvider<CharacterModel>
    {
        public Provider(ICosmosConfiguration config) : base("characters", config)
        {
        }
    }
}
