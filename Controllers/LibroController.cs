using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using USANDROCRUD_Validaciones2404.Datos;
using USANDROCRUD_Validaciones2404.Models;

namespace USANDROCRUD_Validaciones2404.Controllers
{
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }

        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Add(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }

        [Authorize]
        // GET: Editar
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _db.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }

        // POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Update(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }

        [Authorize]
        // GET: Eliminar
        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _db.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }

        // POST: Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro libro)
        {
            if (libro == null)
            {
                return NotFound();
            }

            _db.Libro.Remove(libro);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
