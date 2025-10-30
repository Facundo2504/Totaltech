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
    /// Representa una orden de compra realizada por un usuario.
    public class Pedido
    {
        /// 
        /// Identificador único del pedido.
        
        [Key]
        public int IdPedido { get; set; }

        /// 
        /// Identificador del usuario que realizó el pedido.
        
        
        public int? IdUsuario { get; set; }

        /// Fecha y hora en que se generó el pedido.
        [DataType(DataType.DateTime)]
        public DateTime FechaPedido { get; set; }

        /// Estado actual del ciclo de vida del pedido.
        >
        [Required]
        public EstadoPedido Estado { get; set; } = EstadoPedido.Pendiente;

        /// Método de pago utilizado para abonar el pedido.
        public string MetodoPago { get; set; } = string.Empty;

        /// Identificador de la dirección de entrega o facturación asociada.
        [Required]
        public int IdDireccion { get; set; }

        /// Referencia al usuario dueño del pedido.
        /// </summary>
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        /// <summary>
        /// Dirección vinculada al pedido.
        /// </summary>
        [ForeignKey(nameof(IdDireccion))]
        public Direccion? Direccion { get; set; }

        /// <summary>
        /// Prefactura generada a partir del pedido.
        /// </summary>
        public Prefacturacion? Prefacturacion { get; set; }
    }

    /// Representa los posibles estados por los que pasa un pedido.
    public enum EstadoPedido
    {
        /// Pedido creado pero aún no abonado.
        Pendiente = 0,

        /// Pedido pagado y listo para su preparación.
        Pagado = 1,

        /// Pedido despachado hacia el cliente.
        Enviado = 2,

        /// Pedido entregado satisfactoriamente.
        Entregado = 3,

        /// Pedido cancelado por el usuario o el comercio.
        Cancelado = 4
    }
}