using System;

namespace Entidades
{
    public class Resenia
    {
        public int IdResena { get; set; }

        public int UsuarioId { get; set; }

        public int IdProducto { get; set; }

        public int Calificacion { get; set; }

        public string Comentario { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }

        public Usuario? Usuario { get; set; }

        public Producto? Producto { get; set; }
    }
}
