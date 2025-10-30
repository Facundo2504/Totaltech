using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    public class Facturacion
    {

        [Key]
        public int IdFactura { get; set; }

  
        [Required]
        public int IdPrefactura { get; set; }


        [DataType(DataType.DateTime)] // que devuelva fecha y ahora
        public DateTime FechaEmision { get; set; }

   
         // maximo 50 caracteres
        public string NroFactura { get; set; } = string.Empty;

 
        public decimal Total { get; set; }
 
        [ForeignKey(nameof(IdPrefactura))]// relacion con Prefacturacion
        public Prefacturacion? Prefacturacion { get; set; }
    }
}