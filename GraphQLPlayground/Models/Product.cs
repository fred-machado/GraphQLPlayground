using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GraphQLPlayground.Models;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Sku { get; set; }
    public string Name { get; set; }
    public List<ProductTag> Tags { get; set; } = new List<ProductTag>();
}

public class ProductTag
{
    public string Name { get; set; }
    public string Value { get; set; }
}