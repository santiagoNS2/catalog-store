using System.ComponentModel.DataAnnotations;

namespace catalog_store.Models.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "E campo {0} deve ter no máximo {1} caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public string Nombre { get; set; }
    }
}
