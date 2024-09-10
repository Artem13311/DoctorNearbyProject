using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Persistence.Models.Entities
{

    [Table("Cabinets")]
    public class CabinetEntity : BaseEntity
    {
        public int Number { get; set; }
        public List<DoctorEntity> Doctors { get; set; }
    }
}
