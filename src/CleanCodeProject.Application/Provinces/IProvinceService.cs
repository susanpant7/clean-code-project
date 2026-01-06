namespace CleanCodeProject.Application.Provinces;

public interface IProvinceService
{
    Task<ApiResponse<List<ProvinceInfo>>> GetProvincesAsync();
}