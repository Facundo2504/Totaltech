using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// <summary>
    /// Define una categoría de productos utilizada para organizar el catálogo.
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Identificador único de la categoría.
        /// </summary>
        [Key]
        public int IdCategoria { get; set; }

        /// <summary>
        /// Nombre corto que identifica a la categoría.
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Descripción opcional que amplía la información de la categoría.
        /// </summary>
        [MaxLength(500)]
        public string? Descripcion { get; set; }

        /// <summary>
        /// Productos agrupados dentro de la categoría.
        /// </summary>
        [InverseProperty(nameof(Producto.Categoria))]
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();

        /// <summary>
        /// Promociones o descuentos aplicables a la categoría.
        /// </summary>
        [InverseProperty(nameof(Promocion.Categoria))]
        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
    }
}
