using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace jwtauth.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AddAuthorizationHeader
    {
        private readonly RequestDelegate _next;

        public AddAuthorizationHeader(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            string token = httpContext.Session.GetString("token");
            httpContext.Request.Headers.Add("Authorization", "Bearer " + token);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AddAuthorizationHeaderExtensions
    {
        public static IApplicationBuilder UseAddAuthorizationHeader(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AddAuthorizationHeader>();
        }
    }
}
