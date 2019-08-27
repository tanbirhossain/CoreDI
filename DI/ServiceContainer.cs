
using DAL;
using DAL.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DI
{
    public static class ServiceContainer
    {
        public static void BuildServiceContainer(this IServiceCollection services)
        {
            services.AddSingleton<IValueRepository, ValueRepository>();
        }
    }
}
