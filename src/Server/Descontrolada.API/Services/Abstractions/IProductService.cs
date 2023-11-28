using Descontrolada.API.DTOs;
using Descontrolada.API.DTOs.Products;
using Descontrolada.Business.Entities;

namespace Descontrolada.API.Services.Abstractions;

public interface IProductService 
{
    Task<ResponseBaseDTO<Product>> CreateProductAsync(ProductCreateDTO productDTO);

    Task<ResponseBaseDTO<PaginatedResponseDTO<Product>>> GetAllProductsAsync(int skip, int take);
}