namespace Descontrolada.Blazor.ViewModels;

public class PaginatedItemsViewModel<T>(
    int pageIndex
    , int pageSize
    , int totalItems
    , IEnumerable<T> data) where T : class 
{
   

    public int PageIndex { get; set; } = pageIndex;

    public int PageSize { get; set; } = pageSize;

    public int TotalItems { get; set; } = totalItems;

    public int TotalPages { get; set; } = (int)Math.Ceiling((decimal)totalItems / pageSize);

    public IEnumerable<T> Data { get; set; } = data;
}