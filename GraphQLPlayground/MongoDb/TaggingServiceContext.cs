using GraphQLPlayground.Abstractions;
using GraphQLPlayground.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GraphQLPlayground.MongoDb;

public class TaggingServiceContext : ITaggingServiceContext
{
    private const string ProductCollectionName = "Products";

    public TaggingServiceContext(IOptions<MongoDbSettings> mongoDbSettings)
    {
        var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
        var database = client.GetDatabase(mongoDbSettings.Value.Database);

        Products = database.GetCollection<Product>(ProductCollectionName);
    }

    public IMongoCollection<Product> Products { get; }
}
