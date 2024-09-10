using DoctorNearby.Core.Models.Enums;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Persistence.Interfaces
{
    public interface IPatientRepository : IBaseRepository<PatientEntity>
    {
        Task<List<PatientEntity>> GetAllWithFilterAsync(IQueryable<PatientEntity> patients, 
            EPatientSortFields sortFields, ESortType sortType, CancellationToken cancellationToken);


    }
}
