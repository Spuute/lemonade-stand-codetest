using Lemonade.Stand.Application.Interfaces.Data;
using Lemonade.Stand.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lemonade.Stand.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        
        public async Task SaveChangesAsync(){
            await base.SaveChangesAsync();
        }
    }
}