using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Application.Dto.Recipes {
    public class RecipeResponse {
        public string Name { get; set; }
        public Fruit AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
        public int PricePerGlass { get; set; }
    }
}