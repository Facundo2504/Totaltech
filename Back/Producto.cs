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
        // === Identidad ===
        [Key]
        public int IdProducto { get; set; }   // Clave primaria
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; } = true;  
        public string ImagenUrl { get; set; } = string.Empty;  
        public string Marca { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; }
        public int IdCategoria { get; set; }     // FK a Categoría
        [ForeignKey(nameof(IdCategoria))]// indicamos la relacion con categoria 
        public Categoria? Categoria { get; set; } // Navegación a Categoría
        public int IdProveedor { get; set; }     // FK a Proveedor
        [ForeignKey(nameof(IdProveedor))]
        public Proveedor? Proveedor { get; set; } // Navegación a Proveedor
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>(); // Opiniones de clientes


        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>(); // Descuentos asociados
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
