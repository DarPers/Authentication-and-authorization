using System.Runtime.CompilerServices;

namespace backend_app.CustomMiddlewares
{
    public static class DataWorkerMiddlewareExtensions
    {
        public static IApplicationBuilder UseDataWorker(this IApplicationBuilder app)
        {
            return app.UseMiddleware<DataWorker>();
        }
    }
}
