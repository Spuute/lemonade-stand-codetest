using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Application.Interfaces.Repositories
{
    public interface IFruitRepository
    {
         Task Insert(Fruit entity);
         Task<IEnumerable<Fruit>> GetAll();
         Task<Fruit> GetById(int fruitId);
         Task<Fruit> Update(int fruitId, Fruit entity);
         Task<Fruit> Delete(int fruitId);
         Task SaveAsync();
    }
}