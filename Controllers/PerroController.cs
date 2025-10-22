using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Models;
using Modelo_Veterinaria.Services;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerroController : ControllerBase
    {
        private readonly PerroService _service;

        public PerroController(PerroService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var perro = _service.GetById(id);
            if (perro == null) return NotFound();
            return Ok(perro);
        }

        [HttpPost]
        public IActionResult Create(Perro perro)
        {
            _service.Create(perro);
            return CreatedAtAction(nameof(GetById), new { id = perro.IdMascota }, perro);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Perro perro)
        {
            if (!_service.Update(id, perro)) return NotFound();
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
