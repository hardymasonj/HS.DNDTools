using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Domain.Providers
{
    public interface IDataProvider<T>
    {
        T GetItem(string id);
        void InsertItem(string id, T item);
        void UpdateItem(string id, T item);
        void DeleteItem(string id);
    }
}
