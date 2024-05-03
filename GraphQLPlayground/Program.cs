using GraphQLPlayground.Abstractions;
using GraphQLPlayground.GraphQL;
using GraphQLPlayground.MongoDb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection(nameof(MongoDbSettings)));

builder.Services.AddSingleton<ITaggingServiceContext, TaggingServiceContext>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services
      .AddGraphQLServer()
      .AddQueryType<Query>();

var app = builder.Build();

// Seed
if (app.Environment.IsDevelopment())
{
    var taggingServiceContext = app.Services.GetRequiredService<ITaggingServiceContext>();
    TaggingServiceContextSeed.SeedData(taggingServiceContext.Products);
}

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
