using System.Collections.ObjectModel;
using Lemonade.Stand.Application.Interfaces.Services;
using Lemonade.Stand.Application.Models;
using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.Application.Services
{
    public class FruitPressService : IFruitPressService
    {
        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            // Hämta recept
            // Kontrollera hur många glas som ska göras
            // Kontrollera om det är rätt frukt för recepter
            // Kontrollera om det är rätt antal frukter för antalet glas
            // Kontrollera om det är tillräckligt med pengar betalt
            // Skapa lemonad

            throw new NotImplementedException();

            // _recipeRepo.

            // decimal fruitsNeeded = 0;
            // int price = 0;

            // if(recipe.Name == "Apple Lemonade") {
            //     fruitsNeeded = 2.5M * orderedGlassQuantity;
            //     price = 10 * orderedGlassQuantity;
            // }

            // if(fruits.Count < fruitsNeeded) {
            //     // do something
            // }

            // if(moneyPaid < price) {
            //     // do something
            // }




            // foreach(var fruit in fruits.GetType().GetProperties().Where(x => x.Name == recipe.AllowedFruit.Name)) {
                
            // }


            // if(recipe.AllowedFruit.Name == fruits[0].Name) {

            // }
        }
    }
}