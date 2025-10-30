using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    public class Prefacturacion
    {

        [Key]
        public int IdPrefactura { get; set; }

        [Required]/// propiedad no puede ser nula ni vacía
        public int IdPedido { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaEmision { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Total { get; set; }

        [ForeignKey(nameof(IdPedido))]
        public Pedido? Pedido { get; set; }

        [Required]/// propiedad no puede ser nula ni vacía
        public string NroFactura { get; set; } = string.Empty;
    }
}
