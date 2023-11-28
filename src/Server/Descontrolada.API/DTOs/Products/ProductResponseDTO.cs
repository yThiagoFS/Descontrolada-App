namespace Descontrolada.API.DTOs.Products;

public record ProductResponseDTO(long Id, string Name, string Description, string ProductType, decimal Price, int StockQuantity, DateTime CreatedAt);