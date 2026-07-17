namespace Entidades;

public class Venta
{
    public int IdVenta { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now; // TIMESTAMPTZ -> DateTime
    public decimal? Total { get; set; } // NUMERIC (permite null) -> decimal?
    public int? IdCliente { get; set; } // FK -> int?
}