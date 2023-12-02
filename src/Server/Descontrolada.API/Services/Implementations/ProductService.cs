using AutoMapper;
using Descontrolada.API.DTOs;
using Descontrolada.API.DTOs.Products;
using Descontrolada.API.Services.Abstractions;
using Descontrolada.Business.Entities;
using Descontrolada.Business.Repositories;

namespace Descontrolada.API.Services.Implementations;

public class ProductService(IProductRepository repository, IMapper mapper) : IProductService
{
    private readonly IProductRepository _productRepository = repository;
    private readonly IMapper _mapper = mapper;

    public async Task<ResponseBaseDTO<ProductResponseDTO>> CreateProductAsync(ProductCreateRequestDTO productDTO)
    {
        var product = _mapper.Map<Product>(productDTO);

        await _productRepository.AddAsync(product);

        return new ResponseBaseDTO<ProductResponseDTO>(_mapper.Map<ProductResponseDTO>(product), 200);
    }

    public async Task<ResponseBaseDTO<PaginatedResponseDTO<ProductResponseDTO>>> GetAllProductsAsync(int skip = 0, int take = 5)
    {
        var (productCount, products) = await _productRepository.GetAllPaginatedAsync(skip, take);

        var productResponseDTO = _mapper.Map<IEnumerable<ProductResponseDTO>>(products);
        
        var paginatedResponse = new PaginatedResponseDTO<ProductResponseDTO>(productCount, productResponseDTO);

        return new ResponseBaseDTO<PaginatedResponseDTO<ProductResponseDTO>>(paginatedResponse, 200);
    }
}