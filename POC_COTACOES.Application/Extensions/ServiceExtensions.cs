using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace POC_COTACOES.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigurationApplicationApp(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
