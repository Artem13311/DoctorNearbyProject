using DoctorNearby.Business.Models.DTO.District;
using DoctorNearby.Persistence.Models.Stuff.Enums;


namespace DoctorNearby.Business.Models.DTO.Patient
{
    public class UpdatePatientDto
    {
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public ESex Sex { get; set; }
        public Guid DistrictId { get; set; }
    }
}
