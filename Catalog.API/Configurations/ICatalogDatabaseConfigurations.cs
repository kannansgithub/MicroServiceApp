namespace Catalog.API.Configurations
{
    public interface ICatalogDatabaseConfigurations
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }

    }
}
