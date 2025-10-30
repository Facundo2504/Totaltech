
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// <summary>
    /// Representa a un usuario del sistema con sus datos personales y relaciones de negocio.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Identificador único del usuario dentro de la base de datos.
        /// </summary>
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Rol asignado al usuario para determinar permisos y accesos.
        /// </summary>
   
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