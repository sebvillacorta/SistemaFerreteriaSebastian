namespace Entidades;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Apellido { get; set; } // VARCHAR (permite null) -> string?
    public int? DocumentoIdentidad { get; set; } // INTEGER (permite null) -> int?
}