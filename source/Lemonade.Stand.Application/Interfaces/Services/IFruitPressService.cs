using System.Collections.ObjectModel;
using Lemonade.Stand.Application.Models;
using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Application.Interfaces.Services
{
    public interface IFruitPressService {
        FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}