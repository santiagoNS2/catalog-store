using System.ComponentModel.DataAnnotations;

namespace catalog_store.Models.Entidades
{
    public class DetalleVenta
    {
        public int ID { get; set; }

        public Venta Venta { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]

        public string Comentario { get; set; } = null;

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]

        public decimal Total => Producto == null ? 0 : (decimal)Cantidad * Producto.Precio;
    }
}
