using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Persistence.Repositories
{
    public class CabinetRepository : BaseRepository<CabinetEntity>, ICabinetRepository
    {
        private readonly DataContext _dataContext;

        public CabinetRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
