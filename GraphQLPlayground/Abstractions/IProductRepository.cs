using GraphQLPlayground.Models;

namespace GraphQLPlayground.Abstractions;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductTagsAsync(string[] skus);
}
