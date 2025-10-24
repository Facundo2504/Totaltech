using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public int IdUsuario { get; set; }

        public DateTime FechaPedido { get; set; }

        public EstadoPedido Estado { get; set; } = EstadoPedido.Pendiente;

        public string MetodoPago { get; set; } = string.Empty;

        public int IdDireccion { get; set; }

        public Usuario? Usuario { get; set; }

        public Direccion? Direccion { get; set; }

        public ICollection<CompraProducto> Productos { get; set; } = new List<CompraProducto>();

        public Prefacturacion? Prefacturacion { get; set; }
    }

    public enum EstadoPedido
    {
        Pendiente = 0,
        Pagado = 1,
        Enviado = 2,
        Entregado = 3,
        Cancelado = 4
    }
}
