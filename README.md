### Start mongodb
```
docker compose up -d
```

Sample query:
```
{
    productTags(skus: ["SKU-002", "SKU-004"]) {
      sku
      name
      tags {
        name
        value
      }
    }
}
```

<img width="750" alt="image" src="https://github.com/fred-machado/GraphQLPlayground/assets/159866456/a39ab12a-e932-45fc-b248-04e617b787d3">
