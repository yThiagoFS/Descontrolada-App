namespace Descontrolada.API;

public class ResponseBaseDTO<T> 
{
    public ResponseBaseDTO(T data)
    {
        Data = data;
    }

    public ResponseBaseDTO(bool isSuccess) 
    {
        IsSuccess = isSuccess;
    }

    public List<string> Errors { get; set; } = null!;

    public bool IsSuccess { get; set; } = true;

    public T Data { get; set; } = default!;
}