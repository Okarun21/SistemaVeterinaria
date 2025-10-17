using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Services;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadController : ControllerBase
    {
        private readonly EspecialidadService _service;

        public EspecialidadController(EspecialidadService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Especialidad>> GetAll() => Ok(_service.GetAll());

        [HttpGet("{nombre}")]
        public ActionResult<Especialidad> GetByName(string nombre)
        {
            var esp = _service.GetByName(nombre);
            if (esp == null) return NotFound();
            return Ok(esp);
        }

        [HttpPost]
        public IActionResult Create(Especialidad esp)
        {
            _service.Create(esp);
            return CreatedAtAction(nameof(GetByName), new { nombre = esp.Nombre }, esp);
        }

        [HttpDelete("{nombre}")]
        public IActionResult Delete(string nombre)
        {
            if (!_service.Delete(nombre)) return NotFound();
            return NoContent();
        }
    }
}
