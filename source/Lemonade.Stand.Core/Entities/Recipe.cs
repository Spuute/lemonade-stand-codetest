using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities
{
    public class Recipe : IRecipe
    {
        public string Name { get; }

        public Type AllowedFruit { get; }

        public decimal ConsumptionPerGlass { get; }

        public int PricePerGlass { get; }
    }
}