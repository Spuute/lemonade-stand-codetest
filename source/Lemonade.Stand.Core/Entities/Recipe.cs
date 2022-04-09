using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities 
{
    public class Recipe : IRecipe {
        public int Id { get; set; }
        public string Name { get; set; }
        public Fruit AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
        public int PricePerGlass { get; set; }
    }
}