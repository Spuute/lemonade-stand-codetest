using Lemonade.Stand.Application.Interfaces.Data;
using Lemonade.Stand.Application.Interfaces.Repositories;
using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Infrastructure.Repositories
{
    public class FruitRepository : IFruitRepository
    {
        private readonly IApplicationDbContext _context;
        public FruitRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Insert(Fruit entity) {
            _context.Fruits.Add(entity);
            await SaveAsync();
        }

        public async Task SaveAsync() {
            await _context.SaveChangesAsync();
        }
    }
}