using Catalog.API.Data.Interfaces;
using Catalog.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _context;
        public ProductRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context
                                .Products
                                .Find(x => true)
                                .ToListAsync();
        }
        public async Task<Product> GetProduct(string id)
        {
            return await _context
                               .Products
                               .Find(p => p.Id == id)
                               .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.ElemMatch(p => p.Name, name);
            return await _context
                                .Products
                                .Find(filter)
                                .ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProductsCategory(string category)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Category, category);
            return await _context
                                .Products
                                .Find(filter)
                                .ToListAsync();
        }
        public async Task CreateProduct(Product product)
        {
            await _context.Products.InsertOneAsync(product);
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var updatedResult = await _context
                          .Products
                          .ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);
            if (updatedResult.IsAcknowledged && updatedResult.ModifiedCount > 0)
                return product;
            else
                return null;
        }
        public async Task<bool> DeleteProduct(string Id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, Id);
            var deletedResult = await _context
                               .Products
                               .DeleteOneAsync(filter);
            return deletedResult.IsAcknowledged && deletedResult.DeletedCount > 0;

        }

    }
}
