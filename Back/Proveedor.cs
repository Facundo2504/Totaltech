using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        public int IdProveedor { get; set; }

        /// <summary>
        /// Razón social registrada oficialmente.
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string RazonSocial { get; set; } = string.Empty;

        /// <summary>
        /// Número de CUIT asociado al proveedor.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Cuit { get; set; } = string.Empty;

        /// <summary>
        /// Correo electrónico de contacto comercial.
        /// </summary>
        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string EmailComercial { get; set; } = string.Empty;

        /// <summary>
        /// Teléfono destinado a gestiones comerciales.
        /// </summary>
        [Phone]
        [MaxLength(20)]
        public string TelefonoComercial { get; set; } = string.Empty;

        /// <summary>
        /// Condición frente al IVA declarada por el proveedor.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string CondicionIva { get; set; } = string.Empty;

        /// <summary>
        /// Dirección fiscal registrada para fines legales.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string DireccionFiscal { get; set; } = string.Empty;

        /// <summary>
        /// Plazo de pago acordado en días.
        /// </summary>
        [Range(0, 365)]
        public int PlazoPagoDias { get; set; }

        /// <summary>
        /// Tiempo estimado de entrega desde la confirmación del pedido.
        /// </summary>
        [Range(0, 365)]
        public int TiempoEntregaDias { get; set; }

        /// <summary>
        /// Moneda preferida para operaciones comerciales.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string MonedaPreferida { get; set; } = string.Empty;

        /// <summary>
        /// Indica si el proveedor se encuentra activo para nuevas órdenes.
        /// </summary>
        public bool Activo { get; set; } = true;

        /// <summary>
        /// Productos suministrados por el proveedor.
        /// </summary>
        [InverseProperty(nameof(Producto.Proveedor))]
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}