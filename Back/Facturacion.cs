using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// <summary>
    /// Representa la factura emitida a partir de una prefacturación.
    /// </summary>
    public class Facturacion
    {
        /// <summary>
        /// Identificador único de la factura.
        /// </summary>
        [Key]
        public int IdFactura { get; set; }

        /// <summary>
        /// Identificador de la prefactura asociada.
        /// </summary>
        [Required]
        public int IdPrefactura { get; set; }

        /// <summary>
        /// Fecha de emisión oficial de la factura.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// Número de comprobante de la factura.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string NroFactura { get; set; } = string.Empty;

        /// <summary>
        /// Importe total facturado.
        /// </summary>
        [Range(0, double.MaxValue)]
        public decimal Total { get; set; }

        /// <summary>
        /// Prefacturación de la cual se originó la factura.
        /// </summary>
        [ForeignKey(nameof(IdPrefactura))]
        public Prefacturacion? Prefacturacion { get; set; }
    }
}