using Microsoft.AspNetCore.Mvc.Rendering;

namespace catalog_store.services
{
    public interface IServicioLista
    {
        Task<IEnumerable<SelectListItem>> GetListaCategorias();
    }
}
