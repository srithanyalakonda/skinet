using Core.Entities;
using System.Text.Json;


namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            var productdata = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");

            List<Product>? products = JsonSerializer.Deserialize<List<Product>>(productdata);

            if (products == null) return;

            context.Products.AddRange(products);

            await context.SaveChangesAsync();
        }
    }
}
