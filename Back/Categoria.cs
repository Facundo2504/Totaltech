using System.Collections.Generic;

namespace Entidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();

        public ICollection<Promocion> Promociones { get; set; } = new List<Promocion>();
    }
}
