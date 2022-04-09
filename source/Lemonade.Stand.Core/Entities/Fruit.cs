using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Core.Entities
{
    public class Fruit : IFruit {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}