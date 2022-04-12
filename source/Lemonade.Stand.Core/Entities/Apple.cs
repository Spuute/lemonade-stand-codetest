using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities
{
    public class Apple : IFruit
    {
        public readonly string FruitName;
        public Apple() {
            FruitName = "Apple";
        }
        public string Name =>
            FruitName;
    }
}