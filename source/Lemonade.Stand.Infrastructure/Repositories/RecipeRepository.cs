using Lemonade.Stand.Application.Exceptions;
using Lemonade.Stand.Application.Interfaces.Data;
using Lemonade.Stand.Application.Interfaces.Repositories;
using Lemonade.Stand.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lemonade.Stand.Infrastructure.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IApplicationDbContext _context;
        public RecipeRepository(IApplicationDbContext context) {
            _context = context;
        }
        public async Task<Recipe> Delete(int recipeId)
        {
            var recipe = await _context.Recipes.FirstOrDefaultAsync(x => x.Id == recipeId) ?? throw new NotFoundException("Recipe", recipeId);
            _context.Recipes.Remove(recipe);
            await SaveAsync();
            return recipe;
        }

        public async Task<IEnumerable<Recipe>> GetAll()
        {
            return await _context.Recipes.Include(x => x.AllowedFruit).ToListAsync();
        }

        public async Task<Recipe> GetById(int recipeId)
        {
            return await _context.Recipes.FirstOrDefaultAsync(x => x.Id == recipeId) ?? throw new NotFoundException("Recipe", recipeId);
        }

        public async Task Insert(Recipe entity)
        {
            _context.Recipes.Add(entity);
            await SaveAsync();
        }

        public async Task<Recipe> Update(int recipeId, Recipe entity)
        {
            var recipe = await _context.Recipes.FirstOrDefaultAsync(x => x.Id == recipeId) ?? throw new NotFoundException("Recipe", recipeId);
            recipe.Name = entity.Name;
            recipe.AllowedFruit = entity.AllowedFruit;
            recipe.ConsumptionPerGlass = entity.ConsumptionPerGlass;
            recipe.PricePerGlass = entity.PricePerGlass;
            await SaveAsync();

            return recipe;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}