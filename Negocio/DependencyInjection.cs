using Microsoft.Extensions.DependencyInjection;
using AccesoDatos; // Conecta con la capa de datos

namespace Negocio;

public static class DependencyInjection
{
    public static IServiceCollection AddLogicaNegocio(this IServiceCollection services, string connectionString)
    {
        // Pasa la cadena de conexión a la capa de Acceso a Datos
        services.AddAccesoDatos(connectionString);

        return services;
    }
}
