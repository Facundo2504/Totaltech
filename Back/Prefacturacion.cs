using System;

namespace Entidades
{
    public class Prefacturacion
    {
        public int IdPrefactura { get; set; }

        public int IdPedido { get; set; }

        public DateTime FechaEmision { get; set; }

        public decimal Total { get; set; }

        public Pedido? Pedido { get; set; }

        public Facturacion? Facturacion { get; set; }
    }
}
