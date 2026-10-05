using MyProject.Domain.Common;

namespace MyProject.Domain.Interfaces;

public interface IUnitOfWork
{
    IGenericRepository<T> Repository<T>() where T : BaseEntity;

    Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default);
}
