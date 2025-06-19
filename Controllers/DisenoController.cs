using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using USANDROCRUD_Validaciones2404.Models;

namespace USANDROCRUD_Validaciones2404.Controllers
{
    public class DisenoController : Controller
    {
        private readonly ILogger<DisenoController> _logger;

        public DisenoController(ILogger<DisenoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); // Busca la vista en /Views/Diseno/Index.cshtml
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
