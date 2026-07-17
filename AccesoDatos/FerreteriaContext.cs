using Microsoft.EntityFrameworkCore;
using Entidades; // Conecta con tus clases Producto, Cliente, Venta y DetalleVenta

public class FerreteriaContext : DbContext
{
    // Mapeo de las tablas de la base de datos
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<DetalleVenta> DetallesVentas { get; set; }

    public FerreteriaContext(DbContextOptions<FerreteriaContext> op) : base(op) { }

    protected override void OnModelCreating(ModelBuilder b)
    {
        // Relación: Venta -> Cliente (IdCliente es la clave foránea)
        b.Entity<Venta>()
            .HasOne<Cliente>()
            .WithMany()
            .HasForeignKey(v => v.IdCliente);

        // Relación: DetalleVenta -> Venta (IdVenta es la clave foránea)
        b.Entity<DetalleVenta>()
            .HasOne<Venta>()
            .WithMany()
            .HasForeignKey(d => d.IdVenta);

        // Relación: DetalleVenta -> Producto (IdProducto es la clave foránea)
        b.Entity<DetalleVenta>()
            .HasOne<Producto>()
            .WithMany()
            .HasForeignKey(d => d.IdProducto);
    }
}