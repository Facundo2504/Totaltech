using System;

namespace Entidades
{
    /// <summary>
    /// Representa una orden de compra realizada por un usuario.
    /// </summary>
    public class Pedido
    {
        /// <summary>
        /// Identificador único del pedido.
        /// </summary>
        public int IdPedido { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó el pedido.
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Fecha y hora en que se generó el pedido.
        /// </summary>
        public DateTime FechaPedido { get; set; }

        /// <summary>
        /// Estado actual del ciclo de vida del pedido.
        /// </summary>
        public EstadoPedido Estado { get; set; } = EstadoPedido.Pendiente;

        /// <summary>
        /// Método de pago utilizado para abonar el pedido.
        /// </summary>
        public string MetodoPago { get; set; } = string.Empty;

        /// <summary>
        /// Identificador de la dirección de entrega o facturación asociada.
        /// </summary>
        public int IdDireccion { get; set; }

        /// <summary>
        /// Referencia al usuario dueño del pedido.
        /// </summary>
        public Usuario? Usuario { get; set; }

        /// <summary>
        /// Dirección vinculada al pedido.
        /// </summary>
        public Direccion? Direccion { get; set; }

        /// <summary>
        /// Prefactura generada a partir del pedido.
        /// </summary>
        public Prefacturacion? Prefacturacion { get; set; }
    }

    /// <summary>
    /// Representa los posibles estados por los que pasa un pedido.
    /// </summary>
    public enum EstadoPedido
    {
        /// <summary>
        /// Pedido creado pero aún no abonado.
        /// </summary>
        Pendiente = 0,

        /// <summary>
        /// Pedido pagado y listo para su preparación.
        /// </summary>
        Pagado = 1,

        /// <summary>
        /// Pedido despachado hacia el cliente.
        /// </summary>
        Enviado = 2,

        /// <summary>
        /// Pedido entregado satisfactoriamente.
        /// </summary>
        Entregado = 3,

        /// <summary>
        /// Pedido cancelado por el usuario o el comercio.
        /// </summary>
        Cancelado = 4
    }
}
