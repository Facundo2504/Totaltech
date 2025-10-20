using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    /// <summary>
    /// Representa un producto disponible para la venta en la tienda.
    /// La clase expone constructores explícitos para cubrir los escenarios
    /// de creación controlada por la lógica de dominio y para la
    /// materialización de entidades durante la sincronización y migraciones
    /// de Entity Framework.
    /// </summary>
    public class Producto
    {
        public int Id { get; private set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; private set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; private set; }

        [Range(0, double.MaxValue)]
        public decimal Precio { get; private set; }

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

        /// <summary>
        /// Constructor requerido por Entity Framework para la materialización
        /// del objeto durante las migraciones y la sincronización de datos.
        /// </summary>
        protected Producto()
        {
        }

        /// <summary>
        /// Constructor de conveniencia para la lógica de dominio. Garantiza que
        /// las propiedades obligatorias queden inicializadas antes de persistir
        /// la entidad con Entity Framework.
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

        /// <summary>
        /// Constructor explícito para escenarios donde se requiere poblar todas
        /// las propiedades (por ejemplo durante procesos de sincronización con
        /// fuentes externas o migraciones personalizadas).
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
            FechaActualizacion = DateTime.UtcNow;
        }
    }
}
