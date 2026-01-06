using CleanCodeProject.Application.Provinces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCodeProject.Application;

public static class ApplicationConfig
{
    public static IServiceCollection AddApplicationConfig(this IServiceCollection services)
    {
        // Services
        services.AddScoped<IProvinceService, ProvinceService>();

        return services;
    }
}