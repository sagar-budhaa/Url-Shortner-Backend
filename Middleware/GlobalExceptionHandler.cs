using Microsoft.AspNetCore.Diagnostics;
using Url_Shortner_Backend.DTOs.GlobalErrorHandler;

namespace Url_Shortner_Backend.Middleware;

public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger, RequestDelegate next) : IExceptionHandler
{

    public async Task InvokeAsync(HttpContext httpContext, ILogger<GlobalExceptionHandler> logger)
    {
        try
        {
            await next(httpContext);
        }
        catch (Exception ex)
        {
            await TryHandleAsync(httpContext, ex, CancellationToken.None);
        }
    }
    
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        logger.LogError(exception, "Unhandled exception: {Message}", exception.Message);

        var statusCode = exception switch
        {
            ArgumentNullException => StatusCodes.Status400BadRequest,
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            KeyNotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };

        var title = statusCode switch
        {
            StatusCodes.Status400BadRequest => "Bad Request",
            StatusCodes.Status401Unauthorized => "Unauthorized",
            StatusCodes.Status404NotFound => "Not Found",
            _ => "Internal Server Error"
        };
        
        var exceptionResponse = new ExceptionResponseHandlerDto
        {
            Status = statusCode,
            Title = title,
            Detail = exception.Message
        };

        httpContext.Response.StatusCode = (int)statusCode;

        await httpContext.Response.WriteAsJsonAsync(exceptionResponse, cancellationToken);

        return true;
    }
}