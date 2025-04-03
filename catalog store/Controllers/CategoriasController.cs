using catalog_store.Models.Data;
using catalog_store.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace catalog_store.Controllers
{
    public class CategoriasController : Controller
    {
           private readonly CatalogStoreContex _context;

        public CategoriasController(CatalogStoreContex contex)

        {
            _context = contex;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Lista()
        {
          return View(await _context.Categorias.ToListAsync());
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(categoria);
                    await _context.SaveChangesAsync();
                    TempData["AlertaMessage"] = "Categoria creada correctamente";
                    return RedirectToAction("Lista");
                }
                catch
                {
                    ModelState.AddModelError(string.Empty, "Error al crear la categoria");
                }
            }
            return View(categoria);
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }
            
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        [HttpPost]

        public async Task<IActionResult> Editar(int id, Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoria);
                    await _context.SaveChangesAsync();
                    TempData["AlertaMessage"] = "Categoria editada correctamente !!!";
                    return RedirectToAction("Lista");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(ex.Message, "Error al actualizar la categoria");
                }
            }
            return View(categoria);
        }
    }
}
