using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Application.Interfaces.Repositories
{
    public interface IFruitRepository
    {
         Task Insert(Fruit entity);
         Task SaveAsync();
    }
}