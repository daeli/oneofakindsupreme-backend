using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Backend.Core.Interfaces;
using OneOfAKindSupreme.Backend.Infrastructure.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
