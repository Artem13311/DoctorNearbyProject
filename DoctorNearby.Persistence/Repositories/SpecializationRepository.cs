

using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;

namespace DoctorNearby.Persistence.Repositories
{
    public class SpecializationRepository : BaseRepository<SpecializationEntity>, ISpecializationRepository
    {
        private readonly DataContext _dataContext;

        public SpecializationRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
