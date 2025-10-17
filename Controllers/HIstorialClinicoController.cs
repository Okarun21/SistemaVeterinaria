using Microsoft.AspNetCore.Mvc;
using Modelo_Veterinaria.Services;
using Modelo_Veterinaria.Models;
using System.Collections.Generic;

namespace Modelo_Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistorialClinicoController : ControllerBase
    {
        private readonly HistorialClinicoService _service;

        public HistorialClinicoController(HistorialClinicoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<RegistroClinico>> GetAll() => Ok(_service.GetAllRecords());

    }
}
