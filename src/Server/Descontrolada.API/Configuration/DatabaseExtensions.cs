using Descontrolada.Business.Entities;
using Descontrolada.Data.Contexts;

namespace Descontrolada.API.Configuration;

public static class Configuration 
{
    public static void SeedDatabase(IServiceScope scope) 
    {
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        var products = CreateProducts();

        context.Products.AddRange(products);
        context.SaveChanges();
    }

    private static List<Product> CreateProducts() 
        => new() {
            new Product { Id = 1, Name = "Maçãs Orgânicas", Description = "Maçãs frescas cultivadas organicamente", ProductType = "Orgânico", Price = 5.99m, StockQuantity = 100, CreatedAt = DateTime.Now },
            new Product { Id = 2, Name = "Arroz Integral", Description = "Arroz integral de alta qualidade", ProductType = "Não orgânico", Price = 3.49m, StockQuantity = 50, CreatedAt = DateTime.Now },
            new Product { Id = 3, Name = "Tomates Orgânicos", Description = "Tomates suculentos e orgânicos", ProductType = "Orgânico", Price = 4.99m, StockQuantity = 80, CreatedAt = DateTime.Now },
            new Product { Id = 4, Name = "Sabonete de Lavanda", Description = "Sabonete artesanal de lavanda", ProductType = "Não orgânico", Price = 7.99m, StockQuantity = 20, CreatedAt = DateTime.Now },
            new Product { Id = 5, Name = "Cenouras Orgânicas", Description = "Cenouras frescas e orgânicas", ProductType = "Orgânico", Price = 2.49m, StockQuantity = 120, CreatedAt = DateTime.Now },
            new Product { Id = 6, Name = "Óleo de Oliva Extra Virgem", Description = "Óleo de oliva de alta qualidade", ProductType = "Não orgânico", Price = 9.99m, StockQuantity = 40, CreatedAt = DateTime.Now },
            new Product { Id = 7, Name = "Morangos Orgânicos", Description = "Morangos doces e orgânicos", ProductType = "Orgânico", Price = 6.99m, StockQuantity = 60, CreatedAt = DateTime.Now },
            new Product { Id = 8, Name = "Papel Higiênico", Description = "Rolo de papel higiênico suave e resistente", ProductType = "Não orgânico", Price = 1.99m, StockQuantity = 100, CreatedAt = DateTime.Now },
            new Product { Id = 9, Name = "Abacates Orgânicos", Description = "Abacates maduros e orgânicos", ProductType = "Orgânico", Price = 8.99m, StockQuantity = 30, CreatedAt = DateTime.Now },
            new Product { Id = 10, Name = "Biscoitos de Aveia", Description = "Biscoitos integrais de aveia e mel", ProductType = "Não orgânico", Price = 4.49m, StockQuantity = 70, CreatedAt = DateTime.Now }
        };
}