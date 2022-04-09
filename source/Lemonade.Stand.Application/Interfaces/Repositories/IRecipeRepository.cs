using Lemonade.Stand.Core.Entities;

namespace Lemonade.Stand.Application.Interfaces.Repositories
{
    public interface IRecipeRepository
    {
         Task Insert(Recipe entity);
         Task<IEnumerable<Recipe>> GetAll();
         Task<Recipe> GetById(int recipeId);
         Task<Recipe> Update(int recipeId, Recipe entity);
         Task<Recipe> Delete(int recipeId);
         Task SaveAsync();
    }
}