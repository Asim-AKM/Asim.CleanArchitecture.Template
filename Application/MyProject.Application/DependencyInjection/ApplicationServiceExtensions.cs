using Microsoft.Extensions.DependencyInjection;

namespace MyProject.Application.DependencyInjection;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        // Register application services explicitly here.
        // Example:
        // services.AddScoped<IUserService, UserService>();

        return services;
    }
}
