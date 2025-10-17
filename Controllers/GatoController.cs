using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Models;
using Modelo_Veterinaria.Services;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GatoController : ControllerBase
    {
        private readonly GatoService _service;

        public GatoController(GatoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var gato = _service.GetById(id);
            if (gato == null) return NotFound();
            return Ok(gato);
        }

        [HttpPost]
        public IActionResult Create(Gato gato)
        {
            _service.Create(gato);
            return CreatedAtAction(nameof(GetById), new { id = gato.IdMascota }, gato);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Gato gato)
        {
            if (!_service.Update(id, gato)) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}
