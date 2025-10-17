using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Services;
using Modelo_Veterinaria.Models;

[ApiController]
[Route("api/[controller]")]
public class ServicioMedicoController : ControllerBase
{
    private readonly ServicioMedicoService _service;

    public ServicioMedicoController(ServicioMedicoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var item = _service.GetById(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost]
    public IActionResult Create(ServicioMedico servicio)
    {
        _service.Create(servicio);
        return CreatedAtAction(nameof(GetById), new { id = servicio.Fecha.Ticks }, servicio);
    }

    [HttpPut("{id}")]
    public IActionResult Update(long id, ServicioMedico servicio)
    {
        if (!_service.Update(id, servicio)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        if (!_service.Delete(id)) return NotFound();
        return NoContent();
    }
}
