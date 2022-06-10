using HS.DNDTools.SpellPoints.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.DataAccess.Tests.Providers
{
    internal class TestCosmosConfiguration : ICosmosConfiguration
    {
        public string Account { get; set; }
        public string Key { get; set; }
        public string DatabaseName { get; set; }
    }
}
