using System;

namespace Entidades
{
    /// <summary>
    /// Representa la opinión de un usuario sobre un producto.
    /// </summary>
    public class Resenia
    {
        /// <summary>
        /// Identificador único de la reseña.
        /// </summary>
        public int IdResena { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la reseña.
        /// </summary>
        public int UsuarioId { get; set; }

        /// <summary>
        /// Identificador del producto reseñado.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Calificación otorgada al producto en una escala de 1 a 5.
        /// </summary>
        public int Calificacion { get; set; }

        /// <summary>
        /// Comentario descriptivo del usuario sobre el producto.
        /// </summary>
        public string Comentario { get; set; } = string.Empty;

        /// <summary>
        /// Fecha en la que se realizó la reseña.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Usuario asociado a la reseña.
        /// </summary>
        public Usuario? Usuario { get; set; }

        /// <summary>
        /// Producto al que corresponde la reseña.
        /// </summary>
        public Producto? Producto { get; set; }
    }
}
