using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// <summary>
    /// Representa un producto disponible para la venta en la tienda.
    /// La clase expone constructores explícitos para cubrir los escenarios
    /// de creación controlada por la lógica de dominio y para la
    /// materialización de entidades durante la sincronización y migraciones
    /// de Entity Framework.
    /// Representa un producto disponible para la venta en el catálogo.
    /// </summary>
    public class Producto
    {
        public int Id { get; private set; }
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
        public string Nombre { get; private set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; private set; }
        /// <summary>
        /// Descripción detallada del producto.
        /// </summary>
        [MaxLength(1000)]
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Precio unitario del producto.
        /// </summary>
        [Range(0, double.MaxValue)]
        public decimal Precio { get; private set; }
        public decimal Precio { get; set; }

        /// <summary>
        /// Cantidad disponible en inventario.
        /// </summary>
        [Range(0, int.MaxValue)]
        public int StockDisponible { get; private set; }

        public bool Activo { get; private set; } = true;

        public DateTime FechaCreacion { get; private set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; private set; }

        public int? CategoriaId { get; private set; }

        public Categoria? Categoria { get; private set; }

        public ICollection<Resenia> Resenias { get; private set; } = new List<Resenia>();

        public ICollection<CompraProducto> Compras { get; private set; } = new List<CompraProducto>();

        [Timestamp]
        public byte[]? RowVersion { get; private set; }
        public int Stock { get; set; }

        /// <summary>
        /// Constructor requerido por Entity Framework para la materialización
        /// del objeto durante las migraciones y la sincronización de datos.
        /// Identificador de la categoría a la que pertenece el producto.
        /// </summary>
        protected Producto()
        {
        }
        [Required]
        public int IdCategoria { get; set; }

        /// <summary>
        /// Constructor de conveniencia para la lógica de dominio. Garantiza que
        /// las propiedades obligatorias queden inicializadas antes de persistir
        /// la entidad con Entity Framework.
        /// Identificador del proveedor que suministra el producto.
        /// </summary>
        public Producto(
            string nombre,
            decimal precio,
            int stockDisponible,
            string? descripcion = null,
            int? categoriaId = null,
            bool activo = true)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.", nameof(nombre));
            }

            if (precio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(precio), "El precio no puede ser negativo.");
            }

            if (stockDisponible < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(stockDisponible), "El stock disponible no puede ser negativo.");
            }

            Nombre = nombre.Trim();
            Precio = precio;
            StockDisponible = stockDisponible;
            Descripcion = descripcion?.Trim();
            CategoriaId = categoriaId;
            Activo = activo;
            FechaCreacion = DateTime.UtcNow;
            FechaActualizacion = null;
        }
        [Required]
        public int IdProveedor { get; set; }

        /// <summary>
        /// Constructor explícito para escenarios donde se requiere poblar todas
        /// las propiedades (por ejemplo durante procesos de sincronización con
        /// fuentes externas o migraciones personalizadas).
        /// Marca del producto.
        /// </summary>
        public Producto(
            int id,
            string nombre,
            decimal precio,
            int stockDisponible,
            bool activo,
            DateTime fechaCreacion,
            DateTime? fechaActualizacion,
            string? descripcion,
            int? categoriaId,
            byte[]? rowVersion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.", nameof(nombre));
            }
        [MaxLength(100)]
        public string Marca { get; set; } = string.Empty;

            if (precio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(precio), "El precio no puede ser negativo.");
            }

            if (stockDisponible < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(stockDisponible), "El stock disponible no puede ser negativo.");
            }

            Id = id;
            Nombre = nombre.Trim();
            Precio = precio;
            StockDisponible = stockDisponible;
            Activo = activo;
            FechaCreacion = fechaCreacion;
            FechaActualizacion = fechaActualizacion;
            Descripcion = descripcion?.Trim();
            CategoriaId = categoriaId;
            RowVersion = rowVersion;
        }
        /// <summary>
        /// URL de la imagen representativa del producto.
        /// </summary>
        [Url]
        [MaxLength(500)]
        public string ImagenUrl { get; set; } = string.Empty;

        public void ActualizarInformacion(
            string nombre,
            decimal precio,
            int stockDisponible,
            string? descripcion,
            int? categoriaId,
            bool activo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.", nameof(nombre));
            }
        /// <summary>
        /// Categoría asociada del producto.
        /// </summary>
        [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; }

            if (precio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(precio), "El precio no puede ser negativo.");
            }
        /// <summary>
        /// Proveedor asociado del producto.
        /// </summary>
        [ForeignKey(nameof(IdProveedor))]
        public Proveedor? Proveedor { get; set; }

            if (stockDisponible < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(stockDisponible), "El stock disponible no puede ser negativo.");
            }
        /// <summary>
        /// Reseñas registradas por clientes sobre el producto.
        /// </summary>
        [InverseProperty(nameof(Resenia.Producto))]
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();

            Nombre = nombre.Trim();
            Precio = precio;
            StockDisponible = stockDisponible;
            Descripcion = descripcion?.Trim();
            CategoriaId = categoriaId;
            Activo = activo;
            FechaActualizacion = DateTime.UtcNow;
        }
        /// <summary>
        /// Promociones o descuentos aplicables al producto.
        /// </summary>
        [InverseProperty(nameof(Promocion.Producto))]
        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
    }
}