using Catalog.API.Configurations;
using Catalog.API.Data.Interfaces;
using Catalog.API.Models;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(ICatalogDatabaseConfigurations configuration)
        {
            var client = new MongoClient(configuration.ConnectionString);
            var dataBase = client.GetDatabase(configuration.DatabaseName);
            Products = dataBase.GetCollection<Product>(configuration.CollectionName);

            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
