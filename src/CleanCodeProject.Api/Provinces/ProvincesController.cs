using CleanCodeProject.Application.Provinces;
using Microsoft.AspNetCore.Mvc;

namespace CleanCodeProject.Api.Provinces;

[ApiController]
[Route("api/provinces")]
public class ProvincesController(IProvinceService service) : ControllerBase
{
    public async Task<IActionResult> GetProvinces()
    {
        var response = await service.GetProvincesAsync();
        return Ok(response);
    }
}