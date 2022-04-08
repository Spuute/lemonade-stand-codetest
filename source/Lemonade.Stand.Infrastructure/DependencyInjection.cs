using Lemonade.Stand.Infrastructure.Persistence;
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

            services.AddDbContext<ApplicationDbContext>(opts => opts.UseMySql(configuration.GetConnectionString("Db"), new MariaDbServerVersion(new System.Version(10, 5, 6))));


            return services;
        }
    }
}