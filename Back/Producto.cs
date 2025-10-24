using System.Collections.Generic;

namespace Entidades
{
    /// <summary>
    /// Representa un producto disponible para la venta en el catálogo.
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Identificador único del producto.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Nombre comercial del producto.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Descripción detallada del producto.
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Precio unitario del producto.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Cantidad disponible en inventario.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Identificador de la categoría a la que pertenece el producto.
        /// </summary>
        public int IdCategoria { get; set; }

        /// <summary>
        /// Identificador del proveedor que suministra el producto.
        /// </summary>
        public int IdProveedor { get; set; }

        /// <summary>
        /// Marca del producto.
        /// </summary>
        public string Marca { get; set; } = string.Empty;

        /// <summary>
        /// URL de la imagen representativa del producto.
        /// </summary>
        public string ImagenUrl { get; set; } = string.Empty;

        /// <summary>
        /// Categoría asociada del producto.
        /// </summary>
        public Categoria? Categoria { get; set; }

        /// <summary>
        /// Proveedor asociado del producto.
        /// </summary>
        public Proveedor? Proveedor { get; set; }

        /// <summary>
        /// Reseñas registradas por clientes sobre el producto.
        /// </summary>
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();

        /// <summary>
        /// Promociones o descuentos aplicables al producto.
        /// </summary>
        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
    }
}
