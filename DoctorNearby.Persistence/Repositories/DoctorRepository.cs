using DoctorNearby.Core.Models.Enums;
using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace DoctorNearby.Persistence.Repositories
{
    public class DoctorRepository : BaseRepository<DoctorEntity>, IDoctorRepository
    {
        private readonly DataContext _dataContext;

        public DoctorRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<DoctorEntity>> GetAllWithFilterAsync(
            IQueryable<DoctorEntity> doctors, 
            EDoctorSortFileds sortFields, 
            ESortType sortType, 
            CancellationToken cancellationToken)
        {

            var doctorsWithProperties = doctors.Include(x => x.Cabinet).Include(x => x.Specialization).Include(x => x.District);

            switch (sortFields)
            {
                case EDoctorSortFileds.fullname:
                    return sortType.Equals(ESortType.ascending) ?
                        await doctorsWithProperties.OrderBy(e => e.FullName).ToListAsync(cancellationToken) :
                        await doctorsWithProperties.OrderByDescending(e => e.FullName).ToListAsync(cancellationToken);

                case EDoctorSortFileds.cabinetNumber:
                    return sortType.Equals(ESortType.ascending) ?
                        await doctorsWithProperties.OrderBy(e => e.Cabinet.Number).ToListAsync(cancellationToken) :
                        await doctorsWithProperties.OrderByDescending(e => e.Cabinet.Number).ToListAsync(cancellationToken);

                case EDoctorSortFileds.districtNumber:
                    return sortType.Equals(ESortType.ascending) ?
                        await doctorsWithProperties.OrderBy(e => e.District.Number).ToListAsync(cancellationToken) :
                        await doctorsWithProperties.OrderByDescending(e => e.District.Number).ToListAsync(cancellationToken);

                case EDoctorSortFileds.specializationName:
                    return sortType.Equals(ESortType.ascending) ?
                        await doctorsWithProperties.OrderBy(e => e.Specialization.Name).ToListAsync(cancellationToken) :
                        await doctorsWithProperties.OrderByDescending(e => e.Specialization.Name).ToListAsync(cancellationToken);

                default:
                    return await doctorsWithProperties.ToListAsync(cancellationToken);

            }



        }

        public Task<DoctorEntity?> GetWithAllPropertiesAsync(Guid id,CancellationToken cancellationToken)
        {
            return _dataContext.Doctors.Where(x => x.Id == id)
                .Include(x => x.Cabinet)
                .Include(x => x.District)
                .Include(x => x.Specialization)
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
