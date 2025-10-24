using System;

namespace Entidades
{
    public class Promocion
    {
        public int IdPromocion { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdProducto { get; set; }

        public string Codigo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal PorcentajeDescuento { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public bool Activo { get; set; } = true;

        public Categoria? Categoria { get; set; }

        public Producto? Producto { get; set; }
    }
}
