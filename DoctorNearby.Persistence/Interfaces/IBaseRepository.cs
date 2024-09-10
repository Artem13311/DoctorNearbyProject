using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Persistence.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity, CancellationToken cancellationToken);
        Task UpdateAsync(T entity, CancellationToken cancellationToken);
        Task DeleteAsync(T entity, CancellationToken cancellationToken);
        Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<IQueryable<T>> GetByPage(int page, int pageSize);
    }
}
