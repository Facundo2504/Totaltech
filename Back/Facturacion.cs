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

   
        [Required]// propiedad no puede ser nula ni vacía
        public string NroFactura { get; set; } // numero de factura

 
        public decimal Total { get; set; }
 
        
        public Prefacturacion? Prefacturacion { get; set; }
    }
}