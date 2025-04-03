﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace catalog_store.Models.Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage ="El campo {0} debe tener maximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Nombre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Inventario { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500,ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]

        public string Descripcion { get; set; } = null; 

        [Display(Name = "Foto")]
        public string URlFoto { get; set; } = null;

        public Categoria Categoria { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una categoria.")]

        public int CategoriaId { get; set; }

        [NotMapped]

        public IEnumerable<SelectListItem> Categorias { get; set; }


    }
}
