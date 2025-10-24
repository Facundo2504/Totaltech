using System;
using System.Collections.Generic;

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
        public int IdUsuario { get; set; }

        /// <summary>
        /// Nombre de pila del usuario.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Apellido o apellidos del usuario.
        /// </summary>
        public string Apellido { get; set; } = string.Empty;

        /// <summary>
        /// Correo electrónico de contacto y autenticación.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Contraseña cifrada utilizada para el inicio de sesión.
        /// </summary>
        public string Contrasena { get; set; } = string.Empty;

        /// <summary>
        /// Número telefónico de contacto del usuario.
        /// </summary>
        public string Telefono { get; set; } = string.Empty;

        /// <summary>
        /// Fecha en la que se registró el usuario en la plataforma.
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Rol asignado al usuario para determinar permisos y accesos.
        /// </summary>
        public RolUsuario Rol { get; set; } = RolUsuario.Cliente;

        /// <summary>
        /// Colección de direcciones asociadas al usuario.
        /// </summary>
        public ICollection<Direccion> Direcciones { get; set; } = new List<Direccion>();

        /// <summary>
        /// Pedidos realizados por el usuario.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        /// <summary>
        /// Reseñas creadas por el usuario sobre productos.
        /// </summary>
        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();
    }

    /// <summary>
    /// Enumeración de roles soportados por la plataforma.
    /// </summary>
    public enum RolUsuario
    {
        /// <summary>
        /// Usuario que realiza compras dentro del e-commerce.
        /// </summary>
        Cliente = 0,

        /// <summary>
        /// Usuario con privilegios de administración y gestión.
        /// </summary>
        Administrador = 1
    }
}
