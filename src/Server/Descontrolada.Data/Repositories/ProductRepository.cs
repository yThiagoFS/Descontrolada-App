using Descontrolada.Business.Entities;
using Descontrolada.Business.Repositories;
using Descontrolada.Data.Contexts;

namespace Descontrolada.Data.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository 
{
    public ProductRepository(AppDbContext context) : base(context) {}
}