using System;

namespace Entidades
{
    public class Direccion
    {
        public int IdDireccion { get; set; }

        public int IdUsuario { get; set; }

        public string Calle { get; set; } = string.Empty;

        public string Numero { get; set; } = string.Empty;

        public string Ciudad { get; set; } = string.Empty;

        public string Provincia { get; set; } = string.Empty;

        public string CodigoPostal { get; set; } = string.Empty;

        public string Pais { get; set; } = string.Empty;

        public TipoDireccion Tipo { get; set; } = TipoDireccion.Envio;

        public Usuario? Usuario { get; set; }
    }

    public enum TipoDireccion
    {
        Envio = 0,
        Facturacion = 1,
        Fiscal = 2
    }
}
