using DoctorNearby.Business.Models.DTO.District;
using DoctorNearby.Persistence.Models.Stuff.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Business.Models.DTO.Patient
{
    public class PatientDto
    {
        public Guid Id { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public ESex Sex { get; set; }
        public DistrictDto District { get; set; }
    }
}
