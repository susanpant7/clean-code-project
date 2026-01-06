using CleanCodeProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanCodeProject.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        AuditInterceptor auditInterceptor) : DbContext(options)
{
    public DbSet<Province> Provinces => Set<Province>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(auditInterceptor);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

}