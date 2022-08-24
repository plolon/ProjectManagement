using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProjectManagement.Application
{
    public static class ApplicationServicesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
