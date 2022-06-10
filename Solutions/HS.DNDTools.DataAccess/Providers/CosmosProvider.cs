using HS.DNDTools.SpellPoints.Domain.Configuration;
using HS.DNDTools.SpellPoints.Domain.Providers;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.DataAccess.Providers
{
    public abstract class CosmosProvider<T> : IDataProvider<T>
    {
        protected CosmosClient Client { get; private set; }
        protected Container Container { get; private set; }
        protected string ContainerName { get; private set; }
        protected string DatabaseName { get; private set; }

        public CosmosProvider (string containerName, ICosmosConfiguration config) 
        {
            this.ContainerName = containerName;
            this.DatabaseName = config.DatabaseName;
            this.Client = new CosmosClient(config.Account, config.Key);
            this.Container = this.Client.GetContainer(config.DatabaseName, this.ContainerName);
        }
        public void DeleteItem(string id)
        {
            this.Container.DeleteItemAsync<T>(id, PartitionKey.None).RunSynchronously();
        }

        public T GetItem(string id)
        {
            return this.Container.ReadItemAsync<T>(id, new PartitionKey(id)).Result.Resource;
        }

        public void InsertItem(string id, T item)
        {
            this.Container.CreateItemAsync<T>(item, new PartitionKey(id)).RunSynchronously();
        }

        public void UpdateItem(string id, T item)
        {
            this.Container.UpsertItemAsync<T>(item, new PartitionKey(id)).RunSynchronously();
        }
    }
}
