using GraphQLPlayground.Abstractions;
using GraphQLPlayground.Models;
using MongoDB.Driver;

namespace GraphQLPlayground.MongoDb;

public class ProductRepository : IProductRepository
{
    private readonly ITaggingServiceContext _catalogContext;

    public ProductRepository(ITaggingServiceContext catalogContext)
    {
        _catalogContext = catalogContext ?? throw new ArgumentNullException(nameof(catalogContext));
    }

    public async Task<IEnumerable<Product>> GetProductTagsAsync(string[] skus)
    {
        var filter = Builders<Product>.Filter.In(x => x.Sku, skus);
        return await _catalogContext.Products.Find(filter).ToListAsync();
    }
}
