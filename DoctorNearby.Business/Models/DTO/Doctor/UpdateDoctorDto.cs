

namespace DoctorNearby.Business.Models.DTO.Doctor
{
    public class UpdateDoctorDto
    {
        public string FullName { get; set; }
        public Guid CabinetId{ get; set; }
        public Guid SpecializationId { get; set; }
        public Guid? DistrictId { get; set; }
    }
}
