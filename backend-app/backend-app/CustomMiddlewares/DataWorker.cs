using Microsoft.AspNetCore.Mvc;

namespace backend_app.CustomMiddlewares
{
    public class DataWorker
    {
        public RequestDelegate _next; // требуется для выполнения следующего middleware в последовательности

        public DataWorker(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            Console.WriteLine(httpContext);
            await this._next(httpContext);
        }
    }
}
