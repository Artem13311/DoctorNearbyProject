using DoctorNearby.Core.Models.Enums;
using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace DoctorNearby.Persistence.Repositories
{
    public class PatientRepository : BaseRepository<PatientEntity>, IPatientRepository
    {

        private readonly DataContext _dataContext;

        public PatientRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<PatientEntity>> GetAllWithFilterAsync(
            IQueryable<PatientEntity> patients, 
            EPatientSortFields sortFields, 
            ESortType sortType,
            CancellationToken cancellationToken
            )
        {
            var patientsWithProperties = patients.Include(x => x.District);

            switch (sortFields)
            {
                case EPatientSortFields.surname:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.Surname).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.Surname).ToListAsync(cancellationToken);

                case EPatientSortFields.name:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.Name).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.Name).ToListAsync(cancellationToken);

                case EPatientSortFields.patronymic:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.Patronymic).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.Patronymic).ToListAsync(cancellationToken);

                case EPatientSortFields.birthday:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.Birthday).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.Birthday).ToListAsync(cancellationToken);

                case EPatientSortFields.address:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.Address).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.Address).ToListAsync(cancellationToken);

                case EPatientSortFields.sex:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.Sex).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.Sex).ToListAsync(cancellationToken);

                case EPatientSortFields.districtNumber:
                    return sortType.Equals(ESortType.ascending) ?
                        await patientsWithProperties.OrderBy(e => e.District.Number).ToListAsync(cancellationToken) :
                        await patientsWithProperties.OrderByDescending(e => e.District.Number).ToListAsync(cancellationToken);

                default:
                    return await patientsWithProperties.ToListAsync(cancellationToken);

            }

        }
    }
}
