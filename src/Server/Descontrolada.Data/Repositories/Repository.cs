using Descontrolada.Business.Repositories;
using Descontrolada.Business.Entities;
using Descontrolada.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Descontrolada.Data.Repositories;

public class Repository<T> : IRepository<T> where T : EntityBase
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
        => await _dbSet.AsNoTracking().ToListAsync();

    public async Task<(int, IEnumerable<T>)> GetAllPaginatedAsync(int skip, int take)
    {
        var totalCount = _dbSet.Count();

        var items = await _dbSet.AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToListAsync();

        return (totalCount, items);
    }

    public async Task<T>? GetByIdAsync(long id)
        => await _dbSet.SingleOrDefaultAsync(e => e.Id == id);
    
    public async Task UpdateAsync(T entity)
    {
        var item = _dbSet.Find(entity.Id);

        if(item is not null) 
        {
            _context.Entry(item).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
        }
    }
}