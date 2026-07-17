namespace Entidades;

public class DetalleVenta
{
    public int IdDetalle { get; set; }
    public int IdVenta { get; set; } // NOT NULL -> int
    public int IdProducto { get; set; } // NOT NULL -> int
    public int Cantidad { get; set; } // NOT NULL -> int
    public decimal PrecioUnitario { get; set; } // NOT NULL -> decimal
    public decimal Subtotal { get; set; } // NOT NULL -> decimal
}