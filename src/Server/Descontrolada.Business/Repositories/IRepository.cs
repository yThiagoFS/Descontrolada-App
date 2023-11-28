using Descontrolada.Business.Entities;

namespace Descontrolada.Business.Repositories;

public interface IRepository<T> where T : EntityBase
{
    Task AddAsync(T entity);

    Task DeleteAsync(T entity);

    Task<IEnumerable<T>> GetAllAsync();

    Task<(int Count, IEnumerable<T> Items)> GetAllPaginatedAsync(int skip, int take);

    Task<T>? GetByIdAsync(long id);

    Task UpdateAsync(T entity);
}