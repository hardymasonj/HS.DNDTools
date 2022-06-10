using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Configuration
{
    public interface ICosmosConfiguration
    {
        string Account { get; }
        string Key { get; }
        string DatabaseName { get; }
    }
}
