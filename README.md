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
