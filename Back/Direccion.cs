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
    /// Representa una dirección asociada a un usuario para envíos o facturación.
    /// </summary>
    public class Direccion
    {
        /// <summary>
        /// Identificador único de la dirección.
        /// </summary>
        [Key]
        public int IdDireccion { get; set; }

        /// <summary>
        /// Clave foránea que relaciona la dirección con el usuario propietario.
        /// </summary>
        [Required]
        public int IdUsuario { get; set; }

        /// <summary>
        /// Nombre de la calle correspondiente a la dirección.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Calle { get; set; } = string.Empty;

        /// <summary>
        /// Número de la calle o identificación adicional.
        /// </summary>
        [MaxLength(20)]
        public string Numero { get; set; } = string.Empty;

        /// <summary>
        /// Ciudad en la que se ubica la dirección.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Ciudad { get; set; } = string.Empty;

        /// <summary>
        /// Provincia o estado de la dirección.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Provincia { get; set; } = string.Empty;

        /// <summary>
        /// Código postal que corresponde a la dirección.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string CodigoPostal { get; set; } = string.Empty;

        /// <summary>
        /// País en el que se encuentra la dirección.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Pais { get; set; } = string.Empty;

        /// <summary>
        /// Define el uso principal de la dirección (envío, facturación o fiscal).
        /// </summary>
        [Required]
        public TipoDireccion Tipo { get; set; } = TipoDireccion.Envio;

        /// <summary>
        /// Referencia al usuario que posee la dirección.
        /// </summary>
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }

    /// <summary>
    /// Enumeración que indica el tipo de uso de una dirección.
    /// </summary>
    public enum TipoDireccion
    {
        /// <summary>
        /// Dirección destinada a la entrega de productos.
        /// </summary>
        Envio = 0,

        /// <summary>
        /// Dirección utilizada para emitir facturas.
        /// </summary>
        Facturacion = 1,

        /// <summary>
        /// Dirección registrada con fines fiscales.
        /// </summary>
        Fiscal = 2
    }
}