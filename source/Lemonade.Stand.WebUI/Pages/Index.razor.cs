using System.Collections.ObjectModel;
using Lemonade.Stand.Application.Interfaces.Services;
using Lemonade.Stand.Core.Entities;
using Lemonade.Stand.Core.Interfaces.Entities;
using Microsoft.AspNetCore.Components;

namespace Lemonade.Stand.WebUI.Pages
{
    public partial class Index : ComponentBase
    {
        public Collection<IFruit> Fruits { get; set; }
        public Collection<IRecipe> Recipes { get; set; } = new Collection<IRecipe>();
        public IRecipe Recipe { get; set; }
        public Recipe<Apple> AppleLemonade { get; set; } = new Recipe<Apple>("Apple Lemonade", 2.5M, 10);
        public Recipe<Melon> MelonLemonade { get; set; } = new Recipe<Melon>("Melon Lemonade", 0.5M, 12);
        public Recipe<Orange> OrangeLemonade { get; set; } = new Recipe<Orange>("Orange Lemonade", 1, 9);
        public int MoneyPaid { get; set; } = 10;
        public int OrderedGlasses { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            Recipes.Add(AppleLemonade);
            Recipes.Add(MelonLemonade);
            Recipes.Add(OrangeLemonade);
        }
    }
}