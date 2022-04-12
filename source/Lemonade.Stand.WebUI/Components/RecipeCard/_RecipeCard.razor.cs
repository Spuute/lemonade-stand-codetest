using Lemonade.Stand.Core.Entities;
using Lemonade.Stand.Core.Interfaces.Entities;
using Microsoft.AspNetCore.Components;

namespace Lemonade.Stand.WebUI.Components.RecipeCard
{
    public partial class _RecipeCard : ComponentBase
    {
        [Parameter]
        public IRecipe Recipe { get; set; }

    }
}