namespace Entidades
{
    public class CompraProducto
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public Pedido? Pedido { get; set; }

        public Producto? Producto { get; set; }
    }
}
