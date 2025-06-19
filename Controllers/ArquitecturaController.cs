using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using USANDROCRUD_Validaciones2404.Models;

namespace USANDROCRUD_Validaciones2404.Controllers
{
    public class ArquitecturaController : Controller
    {
        private readonly ILogger<ArquitecturaController> _logger;

        public ArquitecturaController(ILogger<ArquitecturaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); // Busca la vista en /Views/Arquitectura/Index.cshtml
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
