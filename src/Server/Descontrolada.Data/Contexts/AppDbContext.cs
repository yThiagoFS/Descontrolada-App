using Descontrolada.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Descontrolada.Data.Contexts;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) {}

    public DbSet<Product> Products { get; set; }
}