using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Services;
using Modelo_Veterinaria.Models;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeterinarioController : ControllerBase
    {
        private readonly VeterinarioService _service;

        public VeterinarioController(VeterinarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vet = _service.GetById(id);
            if (vet == null) return NotFound();
            return Ok(vet);
        }

        [HttpPost]
        public IActionResult Create(Veterinario veterinario)
        {
            _service.Create(veterinario);
            return CreatedAtAction(nameof(GetById), new { id = veterinario.Id_Persona }, veterinario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Veterinario veterinario)
        {
            if (!_service.Update(id, veterinario)) return NotFound();
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
