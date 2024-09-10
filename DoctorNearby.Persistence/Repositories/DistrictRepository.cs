using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Persistence.Repositories
{
    public class DistrictRepository : BaseRepository<DistrictEntity>, IDistrictRepository
    {
        private readonly DataContext _dataContext;

        public DistrictRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
