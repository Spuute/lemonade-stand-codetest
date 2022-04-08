using Lemonade.Stand.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lemonade.Stand.Application.Interfaces.Data {
    public interface IApplicationDbContext {
        DbSet<Recipe> Recipes { get; set;}
        DbSet<Fruit> Fruits { get; set; }
    }
}