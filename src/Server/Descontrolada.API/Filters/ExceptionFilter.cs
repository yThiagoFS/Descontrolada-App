using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Descontrolada.API.Filters;

public class ExceptionFilter : IExceptionFilter 
{
    public void OnException(ExceptionContext context) 
    {
        ThrowUnknownError(context);
    }

     private static void ThrowUnknownError(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Result = new ObjectResult(new ResponseBaseDTO<string>($"Ocorreu algum erro durante a requisição. {context.Exception.Message}", 500));
    }
}