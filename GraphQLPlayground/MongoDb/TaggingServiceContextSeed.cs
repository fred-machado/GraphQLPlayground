using GraphQLPlayground.Models;
using MongoDB.Driver;

namespace GraphQLPlayground.MongoDb;

public class TaggingServiceContextSeed
{
    public static void SeedData(IMongoCollection<Product> productCollection)
    {
        productCollection.DeleteMany(_ => true);
        productCollection.InsertMany(
            new List<Product>
            {
                new Product
                {
                    Id = "605fbfd4f0d09d08fba6bd80",
                    Sku = "SKU-001",
                    Name = "Product Name One",
                    Tags = new List<ProductTag>
                    {
                        new ProductTag
                        {
                            Name = "Tag Name One",
                            Value = "Tag Value One"
                        },
                        new ProductTag
                        {
                            Name = "Tag Name Two",
                            Value = "Tag Value Two"
                        }
                    }
                },
                new Product
                {
                    Id = "605fbfe4690cd322f1ef0d15",
                    Sku = "SKU-002",
                    Name = "Product Name Two",
                    Tags = new List<ProductTag>
                    {
                        new ProductTag
                        {
                            Name = "Tag Name Three",
                            Value = "Tag Value Three"
                        },
                        new ProductTag
                        {
                            Name = "Tag Name Four",
                            Value = "Tag Value Four"
                        }
                    }
                },
                new Product
                {
                    Id = "605fbff1f0d09d08fba6bd81",
                    Sku = "SKU-003",
                    Name = "Product Name Three",
                    Tags = new List<ProductTag>
                    {
                        new ProductTag
                        {
                            Name = "Tag Name Five",
                            Value = "Tag Value Five"
                        },
                        new ProductTag
                        {
                            Name = "Tag Name Six",
                            Value = "Tag Value Six"
                        }
                    }
                },
                new Product
                {
                    Id = "605fbffcf0d09d08fba6bd82",
                    Sku = "SKU-004",
                    Name = "Product Name Four",
                    Tags = new List<ProductTag>
                    {
                        new ProductTag
                        {
                            Name = "Tag Name Seven",
                            Value = "Tag Value Seven"
                        },
                        new ProductTag
                        {
                            Name = "Tag Name Eight",
                            Value = "Tag Value Eight"
                        }
                    }
                }
            });
    }
}
