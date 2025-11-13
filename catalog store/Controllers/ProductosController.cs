using catalog_store.Models.Data;
using catalog_store.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace catalog_store.Controllers
{
    public class ProductosController : Controller
    {

        private readonly CatalogStoreContex _context;
        private readonly IServicioImagen _servicioImagen;
        private readonly IServicioLista _servicioLista;

        public ProductosController(CatalogStoreContex context, IServicioImagen servicioImagen, IServicioLista servicioLista)
        {
            _context = context;
            _servicioImagen = servicioImagen;
            _servicioLista = servicioLista;
        }

        public  async Task<IActionResult> Lista()
        {
            return View(await _context.Productos
                .Include(p=>p.Categoria)
                .ToListAsync());
        }
    }
}
