namespace Descontrolada.Business.Entities;

public class Product : EntityBase
{
    public string Name { get; set; } 

    public string Description { get; set; } 

    public string ProductType { get; set; } 

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public DateTime CreatedAt { get; set; }
}