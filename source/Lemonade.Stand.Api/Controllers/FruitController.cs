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
    }
}