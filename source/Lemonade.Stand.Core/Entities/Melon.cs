using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities
{
    public class Melon : IFruit {
        public readonly string FruitName;
        public Melon() {
            FruitName = "Melon";
        }
        public string Name =>
            FruitName;
    }
}