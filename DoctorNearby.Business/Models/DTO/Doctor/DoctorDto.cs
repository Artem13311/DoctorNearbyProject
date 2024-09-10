using DoctorNearby.Business.Models.DTO.Cabinet;
using DoctorNearby.Business.Models.DTO.District;
using DoctorNearby.Business.Models.DTO.Specialization;


namespace DoctorNearby.Business.Models.DTO.Doctor
{
    public class DoctorDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public CabinetDto Cabinet { get; set; }
        public SpecializationDto Specialization { get; set; }
        public DistrictDto? District { get; set; }
    }
}
