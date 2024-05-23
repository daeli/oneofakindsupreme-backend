using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;
using OneOfAKindSupreme.Backend.Infrastructure.Data.EF;

namespace OneOfAKindSupreme.Backend.Infrastructure.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection serviceCollection)
        {            
            serviceCollection.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            serviceCollection.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));            
            return serviceCollection;
        }
    }
}
