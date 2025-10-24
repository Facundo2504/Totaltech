using System;

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
        public int IdFactura { get; set; }

        /// <summary>
        /// Identificador de la prefactura asociada.
        /// </summary>
        public int IdPrefactura { get; set; }

        /// <summary>
        /// Fecha de emisión oficial de la factura.
        /// </summary>
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// Número de comprobante de la factura.
        /// </summary>
        public string NroFactura { get; set; } = string.Empty;

        /// <summary>
        /// Importe total facturado.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Prefacturación de la cual se originó la factura.
        /// </summary>
        public Prefacturacion? Prefacturacion { get; set; }
    }
}
