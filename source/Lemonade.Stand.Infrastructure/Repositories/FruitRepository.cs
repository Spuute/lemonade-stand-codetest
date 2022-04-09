using Lemonade.Stand.Application.Exceptions;
using Lemonade.Stand.Application.Interfaces.Data;
using Lemonade.Stand.Application.Interfaces.Repositories;
using Lemonade.Stand.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lemonade.Stand.Infrastructure.Repositories {
    public class FruitRepository : IFruitRepository {
        private readonly IApplicationDbContext _context;
        public FruitRepository(IApplicationDbContext context) {
            _context = context;
        }

        public async Task Insert(Fruit entity) {
            _context.Fruits.Add(entity);
            await SaveAsync();
        }

        public async Task<IEnumerable<Fruit>> GetAll() {
            return await _context.Fruits.ToListAsync();
        }

        public async Task<Fruit> GetById(int fruitId) {
            return await _context.Fruits.FirstOrDefaultAsync(x => x.Id == fruitId) ?? throw new NotFoundException("fruit", fruitId);
        }
        public async Task<Fruit> Update(int fruitId, Fruit entity) {
            var fruit = await _context.Fruits.FirstOrDefaultAsync(x => x.Id == fruitId);
            fruit.Name = entity.Name;
            await SaveAsync();

            return fruit;
        }
        public async Task<Fruit> Delete(int fruitId) {
                var fruit = await _context.Fruits.FirstOrDefaultAsync(x => x.Id == fruitId);
                _context.Fruits.Remove(fruit);
                await SaveAsync();
                return fruit;
        }
        public async Task SaveAsync() {
            await _context.SaveChangesAsync();
        }

    }
}