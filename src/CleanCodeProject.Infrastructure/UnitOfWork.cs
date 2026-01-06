using CleanCodeProject.Domain.Common;
using CleanCodeProject.Infrastructure.Persistence;

namespace CleanCodeProject.Infrastructure;

public class UnitOfWork (ApplicationDbContext context) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }

    public void Dispose()
    {
        context.Dispose();
        GC.SuppressFinalize(this);
    }

    public async ValueTask DisposeAsync()
    {
        await context.DisposeAsync().ConfigureAwait(false);
        GC.SuppressFinalize(this);
    }
}