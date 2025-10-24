using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        public int IdResena { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la reseña.
        /// </summary>
        [Required]
        public int UsuarioId { get; set; }

        /// <summary>
        /// Identificador del producto reseñado.
        /// </summary>
        [Required]
        public int IdProducto { get; set; }

        /// <summary>
        /// Calificación otorgada al producto en una escala de 1 a 5.
        /// </summary>
        [Range(1, 5)]
        public int Calificacion { get; set; }

        /// <summary>
        /// Comentario descriptivo del usuario sobre el producto.
        /// </summary>
        [MaxLength(1000)]
        public string Comentario { get; set; } = string.Empty;

        /// <summary>
        /// Fecha en la que se realizó la reseña.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Usuario asociado a la reseña.
        /// </summary>
        [ForeignKey(nameof(UsuarioId))]
        public Usuario? Usuario { get; set; }

        /// <summary>
        /// Producto al que corresponde la reseña.
        /// </summary>
        [ForeignKey(nameof(IdProducto))]
        public Producto? Producto { get; set; }