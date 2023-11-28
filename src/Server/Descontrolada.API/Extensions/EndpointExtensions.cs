using Descontrolada.API.DTOs.Products;
using Descontrolada.API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Descontrolada.API.Extensions;

public static class EndpointExtensions 
{
    public static void MapProductsEndpoints(this IEndpointRouteBuilder builder) 
    {
        builder.MapGet("/products", async (
            [FromServices] IProductService _productService
            , [FromQuery(Name = "skip")] int skip = 0
            , [FromQuery(Name = "take")] int take = 5) =>
        {
            return Results.Ok(await _productService.GetAllProductsAsync(skip,take));
        });

        builder.MapPost("/products/create", async ([FromBody] ProductCreateRequestDTO request, [FromServices] IProductService _productService) => 
        {
            var productCreated = await _productService.CreateProductAsync(request);

            return Results.Ok(productCreated);
        });
    }
}