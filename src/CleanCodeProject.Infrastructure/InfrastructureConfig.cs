using CleanCodeProject.Domain.Common;
using CleanCodeProject.Domain.IRepositories;
using CleanCodeProject.Infrastructure.Persistence;
using CleanCodeProject.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCodeProject.Infrastructure;

public static class InfrastructureConfig
{
    public static IServiceCollection AddInfrastructureConfig(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Register DbContext
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        services.AddScoped<AuditInterceptor>();

        // Register Repositories
        services.AddScoped<IProvinceRepository, ProvinceRepository>();

        // Register UnitOfWork
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}