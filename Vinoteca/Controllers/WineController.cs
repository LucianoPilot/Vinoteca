using Microsoft.AspNetCore.Mvc;
using Vinoteca.Data.Entities;
using Vinoteca.Repositories;

namespace Vinoteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WineController : ControllerBase
    {
        private readonly WineRepository _repository;

        public WineController(WineRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AddWine([FromBody] Wine wine)
        {
            _repository.AddWine(wine);
            return Ok(wine);
        }

        [HttpGet]
        public IActionResult GetWines()
        {
            var wines = _repository.GetAllWines();
            return Ok(wines);
        }

        [HttpGet("{name}")]
        public IActionResult GetWineByName(string name)
        {
            var wine = _repository.GetWineByName(name);
            if (wine == null) return NotFound();
            return Ok(wine);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStock(int id, [FromBody] int newStock)
        {
            _repository.UpdateStock(id, newStock);
            return Ok();
        }
    }

}
