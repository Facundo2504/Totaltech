using System.Collections.Generic;

namespace Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }

        public string RazonSocial { get; set; } = string.Empty;

        public string Cuit { get; set; } = string.Empty;

        public string EmailComercial { get; set; } = string.Empty;

        public string TelefonoComercial { get; set; } = string.Empty;

        public string CondicionIva { get; set; } = string.Empty;

        public string DireccionFiscal { get; set; } = string.Empty;

        public int PlazoPagoDias { get; set; }

        public int TiempoEntregaDias { get; set; }

        public string MonedaPreferida { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
