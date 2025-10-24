using System;

namespace Entidades
{
    public class Facturacion
    {
        public int IdFactura { get; set; }

        public int IdPrefactura { get; set; }

        public DateTime FechaEmision { get; set; }

        public string NroFactura { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public Prefacturacion? Prefacturacion { get; set; }
    }
}
