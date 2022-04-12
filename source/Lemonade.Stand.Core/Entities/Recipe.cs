using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities 
{
    public class Recipe<T> : IRecipe where T : IFruit, new() {
        public readonly T Ingredience;

        public Recipe(string name, decimal consumptionPerGlass, int price) {
            this.Name = name;
            this.ConsumptionPerGlass = consumptionPerGlass;
            this.PricePerGlass = price;
            Ingredience = new T();
        }
        public string Name { get; }
        public Type AllowedFruit =>
            Ingredience.GetType();
        public decimal ConsumptionPerGlass { get; }
        public int PricePerGlass { get; }
    }
}