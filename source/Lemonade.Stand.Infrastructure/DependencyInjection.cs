using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lemonade.Stand.Infrastructure {
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {
            // if(configuration.GetValue<bool>) {
            //     services.AddDbContext<ApplicationDbContext>(options =>
            //         options.UseInMemoryDatabase("InMemoryDb"));
            // }

            return services;
        }
    }
}