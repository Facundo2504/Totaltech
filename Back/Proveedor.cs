using System.Collections.Generic;

namespace Entidades
{
    /// <summary>
    /// Describe a un proveedor que abastece productos al catálogo.
    /// </summary>
    public class Proveedor
    {
        /// <summary>
        /// Identificador único del proveedor.
        /// </summary>
        public int IdProveedor { get; set; }

        /// <summary>
        /// Razón social registrada oficialmente.
        /// </summary>
        public string RazonSocial { get; set; } = string.Empty;

        /// <summary>
        /// Número de CUIT asociado al proveedor.
        /// </summary>
        public string Cuit { get; set; } = string.Empty;

        /// <summary>
        /// Correo electrónico de contacto comercial.
        /// </summary>
        public string EmailComercial { get; set; } = string.Empty;

        /// <summary>
        /// Teléfono destinado a gestiones comerciales.
        /// </summary>
        public string TelefonoComercial { get; set; } = string.Empty;

        /// <summary>
        /// Condición frente al IVA declarada por el proveedor.
        /// </summary>
        public string CondicionIva { get; set; } = string.Empty;

        /// <summary>
        /// Dirección fiscal registrada para fines legales.
        /// </summary>
        public string DireccionFiscal { get; set; } = string.Empty;

        /// <summary>
        /// Plazo de pago acordado en días.
        /// </summary>
        public int PlazoPagoDias { get; set; }

        /// <summary>
        /// Tiempo estimado de entrega desde la confirmación del pedido.
        /// </summary>
        public int TiempoEntregaDias { get; set; }

        /// <summary>
        /// Moneda preferida para operaciones comerciales.
        /// </summary>
        public string MonedaPreferida { get; set; } = string.Empty;

        /// <summary>
        /// Indica si el proveedor se encuentra activo para nuevas órdenes.
        /// </summary>
        public bool Activo { get; set; } = true;

        /// <summary>
        /// Productos suministrados por el proveedor.
        /// </summary>
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
