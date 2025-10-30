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
        public int IdProducto { get; set; }   // Clave primari
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } 
        public decimal Precio { get; set; }
        public int Stock { get; set; }
               /// [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; } 
        public bool Activo { get; set; } = true;  // Para ocultar o despublicar el producto
        public string ImagenUrl { get; set; } = string.Empty;  // URL de imagen principal
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; }
        
       /// [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; } 


       

        public void ActualizarDatos(string nombre, decimal precio, int stock, string? descripcion = null, string? imagenUrl = null, bool? activo = null)
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
