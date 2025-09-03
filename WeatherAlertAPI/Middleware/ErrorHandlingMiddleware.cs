using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using WeatherAlertAPI.Models;
using WeatherAlertAPI.Constants;

namespace WeatherAlertAPI.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ErrorResponse(
                code: "INTERNAL_SERVER_ERROR",
                message: "Um erro inesperado ocorreu ao processar sua requisição."
            );

            error.AddLink("documentation", "/docs/errors/INTERNAL_SERVER_ERROR");
            error.AddLink("support", ExternalUrls.SUPPORT_URL);

            var result = JsonSerializer.Serialize(error);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await context.Response.WriteAsync(result);
        }
    }
}
