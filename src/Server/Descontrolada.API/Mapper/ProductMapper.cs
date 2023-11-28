using AutoMapper;
using Descontrolada.API.DTOs.Products;
using Descontrolada.Business.Entities;

namespace Descontrolada.API.Mapper;

public class ProductMapper : Profile  
{
    public ProductMapper()
    {
        CreateMap<Product, ProductResponseDTO>();
        CreateMap<ProductCreateRequestDTO, Product>();
    }
}