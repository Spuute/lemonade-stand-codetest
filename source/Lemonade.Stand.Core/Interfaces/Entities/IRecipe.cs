using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Core.Interfaces.Entities
{
    public interface IRecipe
    {
         string Name { get; }
         Fruit AllowedFruit { get; }
         decimal ConsumptionPerGlass { get; }
         int PricePerGlass { get; }
    }
}