using Descontrolada.API.Services.Abstractions;
using Descontrolada.API.Services.Implementations;
using Descontrolada.Business.Repositories;
using Descontrolada.Data.Repositories;

namespace Descontrolada.API.Extensions;

public static class RegisterServicesExtensions  
{
    public static void RegisterServices(this IServiceCollection services) 
    {
        services.AddAutoMapper(typeof(Program).Assembly);
        
        services.AddScoped<IProductService, ProductService>();

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}