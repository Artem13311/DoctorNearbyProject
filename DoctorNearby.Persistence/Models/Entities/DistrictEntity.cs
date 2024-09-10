using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Persistence.Models.Entities
{
    [Table("Districts")]
    public class DistrictEntity : BaseEntity
    {
        public int Number { get; set; }
        public List<PatientEntity>? Patients { get; set; }
        public List<DoctorEntity>? Doctors { get; set; }
    }
}
