using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AccesoDatos;

public static class DependencyInjection
{
    public static IServiceCollection AddAccesoDatos(this IServiceCollection services, string connectionString)
    {
        // Registra el contexto usando PostgreSQL
        services.AddDbContext<FerreteriaContext>(options =>
            options.UseNpgsql(connectionString));

        return services;
    }
}