using System;

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
        public int IdPrefactura { get; set; }

        /// <summary>
        /// Identificador del pedido del cual se origina la prefactura.
        /// </summary>
        public int IdPedido { get; set; }

        /// <summary>
        /// Fecha en la que se emitió la prefactura.
        /// </summary>
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// Importe total registrado en la prefactura.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Pedido asociado a la prefactura.
        /// </summary>
        public Pedido? Pedido { get; set; }

        /// <summary>
        /// Factura definitiva que se genera a partir de la prefactura.
        /// </summary>
        public Facturacion? Facturacion { get; set; }
    }
}
