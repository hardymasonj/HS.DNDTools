using HS.DNDTools.SpellPoints.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.DataAccess.Tests.Providers
{
    public class CosmosTestBase
    {
        public ICosmosConfiguration Configuration { get; private set; }
        public CosmosTestBase()
        {
            //HACK - this is horrible and settings like this should not be hard coded and definitely not put into source control
            this.Configuration = new TestCosmosConfiguration() { Account = "https://dnd-utilities.documents.azure.com:443/", DatabaseName = "dnd-utilities", Key = "Key" }; 
        }
    }
}
