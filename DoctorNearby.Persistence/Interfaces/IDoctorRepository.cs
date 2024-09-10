using DoctorNearby.Core.Models.Enums;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Persistence.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<DoctorEntity>
    {
        Task<List<DoctorEntity>> GetAllWithFilterAsync(IQueryable<DoctorEntity> doctors, EDoctorSortFileds sortFields, ESortType sortType, CancellationToken cancellationToken);
        Task<DoctorEntity?> GetWithAllPropertiesAsync(Guid id, CancellationToken cancellationToken);


    }
}
