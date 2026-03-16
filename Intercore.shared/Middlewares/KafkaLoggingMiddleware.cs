namespace Intercore.shared.middlewares;
using MassTransit;
using shared.DTOs;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
public class KafkaLoggingMiddleware
{
    private readonly RequestDelegate _next;
    
    public KafkaLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IPublishEndpoint publishEndpoint)
    {
        var stopwatch = Stopwatch.StartNew();
        bool isSuccess = true;

        try
        {
            await _next(context); 
        }
        catch (Exception ex)
        {
            isSuccess = false;
            
            var exceptionLog = new CreateExceptionLogDto
            {
                ClassName = ex.Source ?? "Unknown",
                MethodName = context.Request.Path,
                ErrorMessage = ex.Message,
                StackTrace = ex.StackTrace
            };

            await publishEndpoint.Publish(exceptionLog);

            throw; 
        }
        finally
        {
            stopwatch.Stop();

            var accessLog = new CreateAccessLogDto
            {
                IpAddress = context.Connection.RemoteIpAddress?.ToString() ?? "Unknown",
                Action = $"{context.Request.Method} {context.Request.Path}", 
                IsSuccess = isSuccess && context.Response.StatusCode < 400
            };

            await publishEndpoint.Publish(accessLog);
        }
    }

}