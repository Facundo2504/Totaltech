using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Contrasena { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; }

        public RolUsuario Rol { get; set; } = RolUsuario.Cliente;

        public ICollection<Direccion> Direcciones { get; set; } = new List<Direccion>();

        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();
    }

    public enum RolUsuario
    {
        Cliente = 0,
        Administrador = 1
    }
}
