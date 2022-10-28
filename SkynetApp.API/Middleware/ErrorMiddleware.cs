using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace SkynetApp.API.Middleware
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ErrorMiddleware(RequestDelegate next, ILogger<ErrorMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                _next(context);
            }
            catch(Exception ex)
            {
                HandleException(context, ex);
            }
          
        }

        private async Task HandleException(HttpContext context, Exception ex)

        {
            object errors = null;
            switch (ex)
            {
                case Exception e:                   
                    _logger.LogError(ex, "SERVER ERROR");
                   //ogger.Error(ex);
                    errors = string.IsNullOrWhiteSpace(e.Message) ? "ERROR" : ex.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;


            }
            context.Response.ContentType = "application/json";
            if (errors != null)
            {
                var result = JsonSerializer.Serialize(new { errors});
                await context.Response.WriteAsync(result);
            }
        }



    }
}
