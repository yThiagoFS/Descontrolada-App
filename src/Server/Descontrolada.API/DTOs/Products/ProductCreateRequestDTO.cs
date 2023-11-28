namespace Descontrolada.API.DTOs.Products;

public record ProductCreateRequestDTO(string Name, string Description, string ProductType, decimal Price, int StockQuantity, DateTime? CreatedAt);