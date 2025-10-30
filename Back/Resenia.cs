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

    public class Resenia
    {

        [Key]
        public int IdResenia { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Range(1, 5)]
        public int Calificacion { get; set; }

        [MaxLength(1000)]
        public string Comentario { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuario? Usuario { get; set; }

        [ForeignKey(nameof(IdProducto))]
        public Producto? Producto { get; set; }
    }

}