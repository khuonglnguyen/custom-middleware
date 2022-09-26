using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareTutorial
    {
        private readonly RequestDelegate _next;

        public MiddlewareTutorial(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("Hello Readers, this is from Custom Middleware...");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareTutorialExtensions
    {
        public static IApplicationBuilder UseMiddlewareTutorial(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareTutorial>();
        }
    }
}
