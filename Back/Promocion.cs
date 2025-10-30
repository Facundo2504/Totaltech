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

        [Key]
        public int IdPromocion { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdProducto { get; set; }

        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        [Range(0, 100)]
        public decimal PorcentajeDescuento { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaFin { get; set; }

        public bool Activo { get; set; } = true;

        [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; }

        [ForeignKey(nameof(IdProducto))]// relacion con Producto
        public Producto? Producto { get; set; }
    }

}