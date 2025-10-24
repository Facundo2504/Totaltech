using System.Collections.Generic;

namespace Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public int IdCategoria { get; set; }

        public int IdProveedor { get; set; }

        public string Marca { get; set; } = string.Empty;

        public string ImagenUrl { get; set; } = string.Empty;

        public Categoria? Categoria { get; set; }

        public Proveedor? Proveedor { get; set; }

        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();

        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();

        public ICollection<CompraProducto> Compras { get; set; } = new List<CompraProducto>();
    }
}
