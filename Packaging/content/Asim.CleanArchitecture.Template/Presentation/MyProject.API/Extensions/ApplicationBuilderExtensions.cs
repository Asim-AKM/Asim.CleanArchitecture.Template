using MyProject.API.Middleware;

namespace MyProject.API.Extensions;

public static class ApplicationBuilderExtensions
{
    public static WebApplication UseApplicationMiddleware(
        this WebApplication app)
    {
        app.UseMiddleware<GlobalExceptionMiddleware>();

        return app;
    }
}
