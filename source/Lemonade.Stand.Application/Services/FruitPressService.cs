using System.Collections.ObjectModel;
using Lemonade.Stand.Application.Exceptions;
using Lemonade.Stand.Application.Interfaces.Services;
using Lemonade.Stand.Application.Models;
using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Application.Services
{
    public class FruitPressService : IFruitPressService
    {
        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            var fruitsNeeded = orderedGlassQuantity * recipe.ConsumptionPerGlass;
            var totalCost = orderedGlassQuantity * recipe.PricePerGlass;
            
            foreach(var fruit in fruits) {
                if(recipe.AllowedFruit != fruit.GetType()) {
                    throw new WrongFruitException("You are trying to add the wrong fruit for this recipe");
                }
            }

            if(moneyPaid < totalCost) {
                throw new NotEnoughMoneyPaidException("You need to charge more money");
            }

            if(fruits.Count() < fruitsNeeded) {
                throw new NotEnoughFruitsException("You need to add more fruits");
            }

            var result = new FruitPressResult() {
              Beverage = recipe.Name,
              DeliveredGlasses = orderedGlassQuantity,
              MoneyPaid = totalCost  
            };
            return result;
        }
    }
}