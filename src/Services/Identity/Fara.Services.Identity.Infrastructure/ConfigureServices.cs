using Fara.Services.Identity.Application.Common.Interfaces;
using Fara.Services.Identity.Application.Common.Utilities.CustomizIdentity;
using Fara.Services.Identity.Domain.Entity.Permissions;
using Fara.Services.Identity.Domain.Entity.User;
using Fara.Services.Identity.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fara.Services.Identity.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            /*   

             Add-Migration Name -OutputDir Migrations -Context ApplicationDbContext -Project DoubleCode.Infrastructure
             Update-Database  -Context ApplicationDbContext 
             dotnet ef migrations add migrationsname -p DoubleCode.Infrastructure -s DoubleCode.WebUI --context ApplicationDbContext

             */

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DoubleCodeConnection"));
            });
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<PersianIdentityErrorDescriber>();

            return services;

        }
    }
}
