using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// Representa un producto del catálogo.
    /// Modelo simple y directo para usar con EF Core.
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        // === Datos Básicos ===
        [Required]
        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        [Range(0, double.MaxValue)]/// valor minimo 0, maximo el valor mas grande posible
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        public bool Activo { get; set; } = true;
        public string ImagenUrl { get; set; } = string.Empty;// ruta de la imagen

        public string Marca { get; set; } = string.Empty;

        // === Metadata ===
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime? FechaActualizacion { get; set; }

        // === Relaciones ===
        public int IdCategoria { get; set; }

        [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; }
        public int IdProveedor { get; set; }
        [ForeignKey(nameof(IdProveedor))]
        public Proveedor? Proveedor { get; set; }
        
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();
       
        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
        public void ActualizarDatos(string nombre, decimal precio, int stock, string? descripcion = null, string? marca = null, string? imagenUrl = null, bool? activo = null)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.", nameof(nombre));

            if (precio < 0)
                throw new ArgumentOutOfRangeException(nameof(precio), "El precio no puede ser negativo.");

            if (stock < 0)
                throw new ArgumentOutOfRangeException(nameof(stock), "El stock no puede ser negativo.");

            Nombre = nombre.Trim();
            Precio = precio;
            Stock = stock;

            if (descripcion != null)
                Descripcion = descripcion.Trim();

            if (imagenUrl != null)
                ImagenUrl = imagenUrl.Trim();

            if (marca != null)
                Marca = marca.Trim();

            if (activo.HasValue)
                Activo = activo.Value;

            FechaActualizacion = DateTime.UtcNow;
        }


        public void AjustarStock(int cantidad)
        {
            var nuevo = Stock + cantidad;
            if (nuevo < 0)
                throw new InvalidOperationException("La operación deja el stock en negativo.");
            Stock = nuevo;
            FechaActualizacion = DateTime.UtcNow;
        }
    }
}
