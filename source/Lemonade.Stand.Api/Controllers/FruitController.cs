using Lemonade.Stand.Application.Exceptions;
using Lemonade.Stand.Application.Interfaces.Repositories;
using Lemonade.Stand.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lemonade.Stand.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly IFruitRepository _fruitrepo;
        public FruitController(IFruitRepository fruitrepo)
        {
            _fruitrepo = fruitrepo;
        }

        [HttpPost]
        public async Task<IActionResult> AddFruit([FromBody] Fruit entity) {
            await _fruitrepo.Insert(entity);
            await _fruitrepo.SaveAsync();
            return StatusCode(201, $"{entity.Name} saved to database");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFruits() {
            return StatusCode(200, await _fruitrepo.GetAll());
        }

        [HttpGet("{fruitId}")]
        public async Task<IActionResult> GetById(int fruitId) {
            try {
                var fruit = await _fruitrepo.GetById(fruitId);
                return StatusCode(200, fruit);
            } 
            catch(NotFoundException ex) {
                return StatusCode(404, ex.Message);
            }
        }

        [HttpPut("{fruitId}")]
        public async Task<IActionResult> UpdateFruit([FromBody] Fruit entity, int fruitId) {
            return StatusCode(200, _fruitrepo.Update(fruitId, entity));
        }

        [HttpDelete("{fruitId}")]
        public async Task<IActionResult> DeleteFruit(int fruitId) {
            try {
                var fruit = await _fruitrepo.Delete(fruitId);
                return StatusCode(200, $"{fruit.Name} was deleted successfully");
            }
            catch (NotFoundException ex) {
                return StatusCode(404, ex.Message);
            }
        }
    }
}