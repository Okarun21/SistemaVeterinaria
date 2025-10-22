using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Services;
using Modelo_Veterinaria.Models;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _service;

        public PersonaController(PersonaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var persona = _service.GetById(id);
            if (persona == null) return NotFound();
            return Ok(persona);
        }

        [HttpPost]
        public IActionResult Create(Persona persona)
        {
            _service.Create(persona);
            return CreatedAtAction(nameof(GetById), new { id = persona.Id_Persona }, persona);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Persona persona)
        {
            if (!_service.Update(id, persona)) return NotFound();
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
