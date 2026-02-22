using Intercore.shared.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Intercore.shared.Database;

public static class DatabaseRegistrationExtensions
{
    public static IServiceCollection AddIntercoreDatabase(this IServiceCollection services, IConfiguration configuration, string connectionStringName = "DefaultConnection")
    {
        var connectionString = configuration.GetConnectionString(connectionStringName);

        if (string.IsNullOrEmpty(connectionString))
            throw new InvalidOperationException($"La cadena de conexión '{connectionStringName}' no se encontró.");

        services.AddSingleton<IDbConnectionFactory>(new SqlDbConnectionFactory(connectionString));

        return services;
    }
}