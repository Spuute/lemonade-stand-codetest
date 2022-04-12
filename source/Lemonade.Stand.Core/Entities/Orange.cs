using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities
{
    public class Orange : IFruit {
        public readonly string FruitName;
        public Orange() {
            FruitName = "Orange";
        }
        public string Name =>
            FruitName;
    }
}