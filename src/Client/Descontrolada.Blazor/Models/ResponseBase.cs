namespace Descontrolada.Blazor.Models;

public class ResponseBase<T> 
{
    public List<string>? Errors { get; set; } = new();

    public bool IsSuccess { get; set; }

    public T Data { get; set; } = default!;
}