using GraphQLPlayground.Abstractions;
using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL;

public class Query
{
    public Task<IEnumerable<Product>> GetProductTagsAsync([Service] IProductRepository productRepository, string[] skus) =>
        productRepository.GetProductTagsAsync(skus);
}
