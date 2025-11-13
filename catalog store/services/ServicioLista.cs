using catalog_store.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace catalog_store.services
{
    public class ServicioLista : IServicioLista
    {
        private readonly CatalogStoreContex _context;

        public ServicioLista(CatalogStoreContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaCategorias()
        {
            List<SelectListItem> list = await _context.Categorias.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = $"{x.Id}"
            })
               .OrderBy(x => x.Text)
               .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una categoría...]",
                Value = "0"
            });

            return list;
        }
    }
}
