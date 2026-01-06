namespace CleanCodeProject.Domain.Common;

public interface ISoftDeletable
{
    DateTime? DeletedAt { get; set; }
    Guid? DeletedBy { get; set; }
}