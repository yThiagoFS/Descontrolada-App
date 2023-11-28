
namespace Descontrolada.API.DTOs;

public class PaginatedResponseDTO<T>(int totalCount, IEnumerable<T> items) 
{
    public int TotalCount { get; set; } = totalCount;

    public IEnumerable<T> Items { get; set; }= items;
}