using Lemonade.Stand.Core.Interfaces.Entities;
using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Application.Dto.Recipe {
    public class RecipeRequest {
        public string Name { get; set; }
        public Fruit AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
        public int PricePerGlass { get; set; }
    }
}