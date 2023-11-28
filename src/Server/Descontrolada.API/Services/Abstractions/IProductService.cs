using Descontrolada.API.DTOs;
using Descontrolada.API.DTOs.Products;
using Descontrolada.Business.Entities;

namespace Descontrolada.API.Services.Abstractions;

public interface IProductService 
{
    Task<ResponseBaseDTO<ProductResponseDTO>> CreateProductAsync(ProductCreateRequestDTO productDTO);

    Task<ResponseBaseDTO<PaginatedResponseDTO<ProductResponseDTO>>> GetAllProductsAsync(int skip, int take);
}