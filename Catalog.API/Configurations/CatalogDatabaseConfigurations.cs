namespace Catalog.API.Configurations
{
    public class CatalogDatabaseConfigurations : ICatalogDatabaseConfigurations
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
