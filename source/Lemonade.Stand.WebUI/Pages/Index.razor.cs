using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Lemonade.Stand.Application.Models;
using Lemonade.Stand.Core.Entities;
using Lemonade.Stand.Core.Interfaces.Entities;
using Lemonade.Stand.WebUI.Models;
using Microsoft.AspNetCore.Components;


namespace Lemonade.Stand.WebUI.Pages
{
    public partial class Index : ComponentBase
    {
        public Collection<IFruit> Fruits { get; set; } 
        public Collection<IRecipe> Recipes { get; set; }
        public Recipe<Apple> AppleLemonade { get; set; } = new Recipe<Apple>("Apple Lemonade", 2.5M, 10);
        public Recipe<Melon> MelonLemonade { get; set; } = new Recipe<Melon>("Melon Lemonade", 0.5M, 12);
        public Recipe<Orange> OrangeLemonade { get; set; } = new Recipe<Orange>("Orange Lemonade", 1, 9);
        public int MoneyPaid { get; set; } 
        public int OrderedGlasses { get; set; } = 0;
        public int FruitsAdded { get; set; } = 0;
        public IRecipe SelectedRecipe { get; set; }
        public bool ShowApple { get; set; } 
        public bool ShowOrange { get; set; }
        public bool ShowMelon { get; set; } 
        public InputFields InputFields { get; set; } = new InputFields();


        private void InvokedFruitPressService() {
            var apple = new Apple();
            var orange = new Orange();
            var melon = new Melon();
            
            for(int i = 0; i < InputFields.FruitsAdded; i++) {
                if(SelectedRecipe.AllowedFruit == typeof(Apple)) {
                    Fruits.Add(apple);
                } 
                else if(SelectedRecipe.AllowedFruit == typeof(Orange)) {
                    Fruits.Add(orange);
                }
                else {
                    Fruits.Add(melon);
                }
            }
            FruitPressResult receipt = _fruitPressService.Produce(SelectedRecipe, Fruits , InputFields.MoneyPaid, InputFields.OrderedGlasses);
            NavManager.NavigateTo("/receipt");
        }
        private void SetSelectedRecipe(ChangeEventArgs e){
                int recipeNumber = int.Parse(e.Value.ToString());
                SelectedRecipe = Recipes[recipeNumber];

                if(SelectedRecipe.AllowedFruit == typeof(Apple)) {
                    ShowApple = true;
                    ShowOrange = false;
                    ShowMelon = false;
                } 
                else if(SelectedRecipe.AllowedFruit == typeof(Orange)) {
                    ShowApple = false;
                    ShowOrange = true;
                    ShowMelon = false;
                }
                else {
                    ShowApple = false;
                    ShowOrange = false;
                    ShowMelon = true;
                }
        }

        protected override async Task OnInitializedAsync()
        {
            Fruits = new Collection<IFruit>();
            Recipes = new Collection<IRecipe>();
            Recipes.Add(AppleLemonade);
            Recipes.Add(MelonLemonade);
            Recipes.Add(OrangeLemonade);
        }
    }
}