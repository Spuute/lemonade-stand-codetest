using Lemonade.Stand.Application.Exceptions;
using Lemonade.Stand.Application.Interfaces.Repositories;
using Lemonade.Stand.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lemonade.Stand.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase {
        private readonly IRecipeRepository _recipeRepo;
        public RecipesController(IRecipeRepository recipeRepo) {
            _recipeRepo = recipeRepo;
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe([FromBody] Recipe entity) {
            await _recipeRepo.Insert(entity);
            await _recipeRepo.SaveAsync();
            return StatusCode(201, $"{entity.Name} saved to Database");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecipes() {
            return StatusCode(200, await _recipeRepo.GetAll());
        }

        [HttpGet("{recipeId}")]
        public async Task<IActionResult> GetById(int recipeId) {
            try {
                var recipe = await _recipeRepo.GetById(recipeId);
                return StatusCode(200, recipe);
            }
            catch (NotFoundException ex) {
                return StatusCode(404, ex.Message);
            }
        }

        [HttpPut("{recipeId}")]
        public async Task<IActionResult> UpdateRecipe([FromBody] Recipe entity, int recipeId) {
            return StatusCode(200, await _recipeRepo.Update(recipeId, entity));
        }

        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> Delete(int recipeId) {
            try {
                var recipe = await _recipeRepo.Delete(recipeId);
                return StatusCode(200, $"{recipe.Name} was deleted successfully");
            }
            catch(NotFoundException ex) {
                return StatusCode(404, ex.Message);
            }
        }
    }
}