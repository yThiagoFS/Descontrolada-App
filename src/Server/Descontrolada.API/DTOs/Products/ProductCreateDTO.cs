namespace Descontrolada.API.DTOs.Products;

public record ProductCreateDTO(string Name, string Description, string ProductType, decimal Price, int StockQuantity);