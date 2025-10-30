using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    public class Proveedor
    {

        [Key]
        public int IdProveedor { get; set; }

        public string RazonSocial { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Cuit { get; set; } = string.Empty;


        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string EmailComercial { get; set; } = string.Empty;

        [Phone]
        [MaxLength(20)]
        public string TelefonoComercial { get; set; } = string.Empty;


        [Required]
        [MaxLength(100)]
        public string CondicionIva { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string DireccionFiscal { get; set; } = string.Empty;

        [Range(0, 365)]
        public int PlazoPagoDias { get; set; }

 
        [Range(0, 365)]
        public int TiempoEntregaDias { get; set; }

        [Required]
        [MaxLength(10)]
        public string MonedaPreferida { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;


        [InverseProperty(nameof(Producto.Proveedor))]
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}