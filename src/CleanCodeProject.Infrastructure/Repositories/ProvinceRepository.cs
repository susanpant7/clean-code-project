using CleanCodeProject.Domain.Entities;
using CleanCodeProject.Domain.IRepositories;
using CleanCodeProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanCodeProject.Infrastructure.Repositories;

public class ProvinceRepository(ApplicationDbContext context) : IProvinceRepository
{
    public async Task<List<Province>> GetAllProvincesAsync()
    {
        return await context.Provinces
            .OrderBy(p => p.ProvinceId)
            .ToListAsync();
    }
}
