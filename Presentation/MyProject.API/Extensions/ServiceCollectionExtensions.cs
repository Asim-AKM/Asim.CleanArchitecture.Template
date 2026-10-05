using MyProject.Application.DependencyInjection;
using MyProject.Infrastructure.DependencyInjection;

namespace MyProject.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString =
            configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "DefaultConnection connection string was not found.");

        services.AddApplication();
        services.AddInfrastructure(connectionString);

        return services;
    }
}
