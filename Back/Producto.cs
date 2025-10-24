using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        public int IdProducto { get; set; }

        /// <summary>
        /// Nombre comercial del producto.
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Descripción detallada del producto.
        /// </summary>
        [MaxLength(1000)]
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Precio unitario del producto.
        /// </summary>
        [Range(0, double.MaxValue)]
        public decimal Precio { get; set; }

        /// <summary>
        /// Cantidad disponible en inventario.
        /// </summary>
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        /// <summary>
        /// Identificador de la categoría a la que pertenece el producto.
        /// </summary>
        [Required]
        public int IdCategoria { get; set; }

        /// <summary>
        /// Identificador del proveedor que suministra el producto.
        /// </summary>
        [Required]
        public int IdProveedor { get; set; }

        /// <summary>
        /// Marca del producto.
        /// </summary>
        [MaxLength(100)]
        public string Marca { get; set; } = string.Empty;

        /// <summary>
        /// URL de la imagen representativa del producto.
        /// </summary>
        [Url]
        [MaxLength(500)]
        public string ImagenUrl { get; set; } = string.Empty;

        /// <summary>
        /// Categoría asociada del producto.
        /// </summary>
        [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; }

        /// <summary>
        /// Proveedor asociado del producto.
        /// </summary>
        [ForeignKey(nameof(IdProveedor))]
        public Proveedor? Proveedor { get; set; }

        /// <summary>
        /// Reseñas registradas por clientes sobre el producto.
        /// </summary>
        [InverseProperty(nameof(Resenia.Producto))]
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();

        /// <summary>
        /// Promociones o descuentos aplicables al producto.
        /// </summary>
        [InverseProperty(nameof(Promocion.Producto))]
        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
    }
}
