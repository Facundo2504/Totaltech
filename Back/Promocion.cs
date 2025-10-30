using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
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
        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; } = string.Empty;

        /// <summary>
        /// Descripción visible de los beneficios de la promoción.
        /// </summary>
        [MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Porcentaje de descuento otorgado por la promoción.
        /// </summary>
        [Range(0, 100)]
        public decimal PorcentajeDescuento { get; set; }

        /// <summary>
        /// Fecha de inicio de vigencia de la promoción.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha de finalización de la promoción.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime FechaFin { get; set; }

        /// <summary>
        /// Indica si la promoción se encuentra activa.
        /// </summary>
        public bool Activo { get; set; } = true;

        /// <summary>
        /// Categoría relacionada con la promoción, cuando corresponda.
        /// </summary>
        [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; }

        /// <summary>
        /// Producto relacionado con la promoción, cuando corresponda.
        /// </summary>
        [ForeignKey(nameof(IdProducto))]
        public Producto? Producto { get; set; }
    }

}