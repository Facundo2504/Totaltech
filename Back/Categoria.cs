using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// <summary>
    /// Representa una categoría de productos.
    /// Clase mínima para las relaciones con Producto y Promoción.
    /// </summary>
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        [InverseProperty(nameof(Producto.Categoria))]
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
