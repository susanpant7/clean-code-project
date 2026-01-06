using CleanCodeProject.Domain.Entities;

namespace CleanCodeProject.Domain.IRepositories;

public interface IProvinceRepository
{
    Task<List<Province>> GetAllProvincesAsync();
}