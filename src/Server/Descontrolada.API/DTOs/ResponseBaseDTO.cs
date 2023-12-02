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
    } 
    

    public ResponseBaseDTO(string error, int statusCode) 
    {
        Errors.Add(error);
        StatusCode = statusCode;
    }


    public List<string> Errors { get; set; } = new();

    public bool IsSuccess => Errors?.Any() ?? true;

    public int StatusCode = 200;

    public T Data { get; set; } = default!;
}