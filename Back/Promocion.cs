using System;

namespace Entidades
{
    /// <summary>
    /// Representa una promoción o descuento aplicable a productos o categorías.
    /// </summary>
    public class Promocion
    {
        /// <summary>
        /// Identificador único de la promoción.
        /// </summary>
        public int IdPromocion { get; set; }

        /// <summary>
        /// Identificador opcional de la categoría a la que aplica la promoción.
        /// </summary>
        public int? IdCategoria { get; set; }

        /// <summary>
        /// Identificador opcional del producto específico al que aplica la promoción.
        /// </summary>
        public int? IdProducto { get; set; }

        /// <summary>
        /// Código único utilizado para activar la promoción.
        /// </summary>
        public string Codigo { get; set; } = string.Empty;

        /// <summary>
        /// Descripción visible de los beneficios de la promoción.
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Porcentaje de descuento otorgado por la promoción.
        /// </summary>
        public decimal PorcentajeDescuento { get; set; }

        /// <summary>
        /// Fecha de inicio de vigencia de la promoción.
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha de finalización de la promoción.
        /// </summary>
        public DateTime FechaFin { get; set; }

        /// <summary>
        /// Indica si la promoción se encuentra activa.
        /// </summary>
        public bool Activo { get; set; } = true;

        /// <summary>
        /// Categoría relacionada con la promoción, cuando corresponda.
        /// </summary>
        public Categoria? Categoria { get; set; }

        /// <summary>
        /// Producto relacionado con la promoción, cuando corresponda.
        /// </summary>
        public Producto? Producto { get; set; }
    }
}
