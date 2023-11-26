using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Fara.Services.Identity.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Add any other services needed for the application

            return services;
        }
    }
}
