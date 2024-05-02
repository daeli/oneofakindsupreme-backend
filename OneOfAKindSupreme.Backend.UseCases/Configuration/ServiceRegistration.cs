using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OneOfAKindSupreme.Backend.UseCases.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterUseCaseServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(config => config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return serviceCollection;
        }
    }
}
