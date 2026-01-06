using Microsoft.AspNetCore.Mvc.Authorization;

namespace CleanCodeProject.Api;

public static class ApiConfig
{
    public static IServiceCollection AddApiConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpContextAccessor();
        return services;
    }

    public static IApplicationBuilder UseApiConfiguration(this WebApplication app)
    {
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}
