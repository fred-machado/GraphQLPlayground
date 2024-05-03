using GraphQLPlayground.Models;
using MongoDB.Driver;

namespace GraphQLPlayground.Abstractions;

public interface ITaggingServiceContext
{
    IMongoCollection<Product> Products { get; }
}
