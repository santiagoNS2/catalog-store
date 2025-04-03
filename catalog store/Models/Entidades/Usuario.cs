using System.ComponentModel.DataAnnotations;
using catalog_store.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace catalog_store.Models.Entidades
{
    public class Usuario : IdentityUser  
    {
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Nombre { get; set; }

        [Display(Name = "Foto")]

        public string URlFoto { get; set; } = null;

        public TipoUsuario TipoUsuario { get; set; }

    }
}
