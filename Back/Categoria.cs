using System.Collections.Generic;

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
        public int IdCategoria { get; set; }

        /// <summary>
        /// Nombre corto que identifica a la categoría.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Descripción opcional que amplía la información de la categoría.
        /// </summary>
        public string? Descripcion { get; set; }

        /// <summary>
        /// Productos agrupados dentro de la categoría.
        /// </summary>
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();

        /// <summary>
        /// Promociones o descuentos aplicables a la categoría.
        /// </summary>
        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
    }
}
