using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Backend.Core.Interfaces.Api;
using OneOfAKindSupreme.Backend.Core.Services;

namespace OneOfAKindSupreme.Backend.Core.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(ILinkService), typeof(LinkService));            
            return serviceCollection;
        }
    }
}
