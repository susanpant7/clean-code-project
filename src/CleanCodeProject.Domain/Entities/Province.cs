using CleanCodeProject.Domain.Common;

namespace CleanCodeProject.Domain.Entities;

public class Province : BaseAuditableEntity
{
    public int ProvinceId { get; set; }
    public string ProvinceName { get; set; }
}