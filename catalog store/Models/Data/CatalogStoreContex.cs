using catalog_store.Models.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace catalog_store.Models.Data
{
    public class CatalogStoreContex : IdentityDbContext<Usuario>
    {
        public CatalogStoreContex(DbContextOptions<CatalogStoreContex> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }    

        public DbSet<VentaTemporal> VentasTemporales { get; set; }

        public DbSet<DetalleVenta> detalleVentas { get; set; }

        public DbSet<Venta> Ventas { get; set; }


    }
}
