using Microsoft.EntityFrameworkCore;
using Entidades; 

public class FerreteriaContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<DetalleVenta> DetallesVentas { get; set; }

    public FerreteriaContext(DbContextOptions<FerreteriaContext> op) : base(op) { }

    protected override void OnModelCreating(ModelBuilder b)
    {
        // 1. Definir Llaves Primarias (PK) explícitamente
        b.Entity<Cliente>().HasKey(c => c.IdCliente);
        b.Entity<Producto>().HasKey(p => p.IdProducto);
        b.Entity<Venta>().HasKey(v => v.IdVenta);
        
        // (Nota: Si tu clase DetalleVenta usa otro nombre de llave primaria, cámbialo aquí)
        b.Entity<DetalleVenta>().HasKey(d => d.IdDetalle); 

        // 2. Definir Llaves Foráneas (Relaciones)
        // Relación: Venta -> Cliente
        b.Entity<Venta>()
            .HasOne<Cliente>()
            .WithMany()
            .HasForeignKey(v => v.IdCliente);

        // Relación: DetalleVenta -> Venta
        b.Entity<DetalleVenta>()
            .HasOne<Venta>()
            .WithMany()
            .HasForeignKey(d => d.IdVenta);

        // Relación: DetalleVenta -> Producto
        b.Entity<DetalleVenta>()
            .HasOne<Producto>()
            .WithMany()
            .HasForeignKey(d => d.IdProducto);
    }
}