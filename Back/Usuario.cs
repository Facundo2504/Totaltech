
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    /// Representa a un usuario del sistema con sus datos personales y relaciones de negocio.

    public class Usuario
    {
        /// Identificador único del usuario dentro de la base de datos.
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Email { get; set; } 
        public string Contrasena { get; set; }
        public string Telefono { get; set; } 

        [DataType(DataType.DateTime)]
        public DateTime FechaRegistro { get; set; }

  
        /// Rol asignado al usuario para determinar permisos y accesos.
   
        public RolUsuario Rol { get; set; } = RolUsuario.Cliente;

        public ICollection<Direccion> Direcciones { get; set; } = new List<Direccion>();

 
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();// reseñas realizadas por el usuario
    }

    public enum RolUsuario
    {

        Cliente = 0,

        Administrador = 1
    }
}