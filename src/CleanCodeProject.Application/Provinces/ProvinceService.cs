using CleanCodeProject.Domain.IRepositories;

namespace CleanCodeProject.Application.Provinces;

public class ProvinceService(IProvinceRepository provinceRepository) : IProvinceService
{
    public async Task<ApiResponse<List<ProvinceInfo>>> GetProvincesAsync()
    {
        var provinces = await provinceRepository.GetAllProvincesAsync();
        var dto = provinces.Select(p => new ProvinceInfo
        {
            ProvinceId = p.ProvinceId,
            ProvinceName = p.ProvinceName,
        }).ToList();

        return ApiResponse<List<ProvinceInfo>>.SuccessResponse(dto);
    }
}