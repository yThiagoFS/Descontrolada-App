using System.ComponentModel.DataAnnotations;

namespace Descontrolada.Blazor.ViewModels;

public class ProductViewModel 
{
    public long Id { get; set; }

    [Required(ErrorMessage = "O produto deve conter um nome")]
    [MinLength(3, ErrorMessage = "Insira um nome válido para o produto")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "O produto deve conter uma descrição")]
    [MinLength(5, ErrorMessage = "Insira uma descrição válida")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "O produto deve conter um preço")]
    [Range(0.05, double.MaxValue, ErrorMessage = "Valor do produto inválido")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Tipo do produto inválido")]
    public string ProductType { get; set; } = string.Empty;

    public int StockQuantity { get; set; } = 0;

    public DateTime CreatedAt { get; set; }
}