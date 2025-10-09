using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TotalTech.Entidades;

public class TotalTechContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }

    protected override void OnConfiguring ( DbContextOptionsBuilder options )
    {
        options.UseSqlServer ("Server=localhost;Database=TotalTechDb;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
