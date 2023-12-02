namespace Descontrolada.API;

public class ResponseBaseDTO<T> 
{
    public ResponseBaseDTO(T data, int statusCode)
    {
        Data = data;
        StatusCode = statusCode;
    }
    

    public ResponseBaseDTO(List<string> errors, int statusCode)
    {
        Errors = errors;
        StatusCode = statusCode;
        IsSuccess = false;
    } 
    

    public ResponseBaseDTO(string error, int statusCode) 
    {
        Errors.Add(error);
        StatusCode = statusCode;
        IsSuccess = false;
    }


    public List<string> Errors { get; set; } = new();

    public bool IsSuccess { get; set; } = true;

    public int StatusCode = 200;

    public T Data { get; set; } = default!;
}