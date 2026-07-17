namespace Entidades;

public class Producto
{
    public int IdProducto { get; set; } // SERIAL -> int
    public string Nombre { get; set; } = string.Empty; // VARCHAR NOT NULL
    public decimal Precio { get; set; } // NUMERIC -> decimal
    public int? Cantidad { get; set; } // INTEGER (permite null) -> int?
}