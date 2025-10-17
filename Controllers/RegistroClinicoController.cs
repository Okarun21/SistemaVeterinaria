using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Services;
using Modelo_Veterinaria.Models;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroClinicoController : ControllerBase
    {
        private readonly RegistroClinicoService _service;

        public RegistroClinicoController(RegistroClinicoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var registro = _service.GetById(id);
            if (registro == null) return NotFound();
            return Ok(registro);
        }

        [HttpPost]
        public IActionResult Create(RegistroClinico registro)
        {
            _service.Create(registro);
            return CreatedAtAction(nameof(GetById), new { id = registro.IdRegistroClinico }, registro);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, RegistroClinico registro)
        {
            if (!_service.Update(id, registro)) return NotFound();
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
