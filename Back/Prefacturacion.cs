using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// <summary>
    /// Representa la prefactura generada previo a la emisión de la factura definitiva.
    /// </summary>
    public class Prefacturacion
    {
        /// <summary>
        /// Identificador único de la prefactura.
        /// </summary>
        [Key]
        public int IdPrefactura { get; set; }

        /// <summary>
        /// Identificador del pedido del cual se origina la prefactura.
        /// </summary>
        [Required]
        public int IdPedido { get; set; }

        /// <summary>
        /// Fecha en la que se emitió la prefactura.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// Importe total registrado en la prefactura.
        /// </summary>
        [Range(0, double.MaxValue)]
        public decimal Total { get; set; }

        /// <summary>
        /// Pedido asociado a la prefactura.
        /// </summary>
        [ForeignKey(nameof(IdPedido))]
        public Pedido? Pedido { get; set; }

        /// <summary>
        /// Factura definitiva que se genera a partir de la prefactura.
        /// </summary>
        public Facturacion? Facturacion { get; set; }
    }
}
