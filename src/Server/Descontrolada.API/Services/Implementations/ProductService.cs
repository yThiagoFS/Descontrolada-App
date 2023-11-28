using Descontrolada.API.DTOs;
using Descontrolada.API.DTOs.Products;
using Descontrolada.API.Services.Abstractions;
using Descontrolada.Business.Entities;
using Descontrolada.Business.Repositories;

namespace Descontrolada.API.Services.Implementations;

public class ProductService(IProductRepository repository) : IProductService
{
    private readonly IProductRepository _productRepository = repository;

    public async Task<ResponseBaseDTO<Product>> CreateProductAsync(ProductCreateDTO productDTO)
    {
        var product = new Product() 
        {
            Name = productDTO.Name,
            Description = productDTO.Description,
            ProductType = productDTO.ProductType,
            Price = productDTO.Price,
            StockQuantity = productDTO.StockQuantity
        };

        await _productRepository.AddAsync(product);

        return new ResponseBaseDTO<Product>(product);
    }

    public async Task<ResponseBaseDTO<PaginatedResponseDTO<Product>>> GetAllProductsAsync(int skip = 0, int take = 5)
    {
        var products = await _productRepository.GetAllPaginatedAsync(skip, take);
        
        var paginatedResponse = new PaginatedResponseDTO<Product>(products.Item1, products.Item2);

        return new ResponseBaseDTO<PaginatedResponseDTO<Product>>(paginatedResponse);
    }
}