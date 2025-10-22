using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Modelo_Veterinaria.Controllers
{
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)] // Ignora este controlador en Swagger
    public class MascotaController : Controller
    {
        private readonly ILogger<MascotaController> _logger;
        public MascotaController(ILogger<MascotaController> logger)
        {
            _logger = logger;
        }

        [HttpGet] // Indica que este método responde a GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("error")] // Método para manejo de errores, también con verbo HTTP explícito
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
