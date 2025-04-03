﻿using System.ComponentModel.DataAnnotations;

namespace catalog_store.Models.Entidades
{
    public class VentaTemporal
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200,ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]

        public string Comentario { get; set; } = null;

        [DisplayFormat(DataFormatString = "{0:C2}")]

        public decimal Total => Producto == null ? 0 : Producto.Precio * Cantidad;

    }
}
