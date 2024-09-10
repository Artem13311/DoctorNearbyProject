
using DoctorNearby.Business.MappingProfiles.Base;
using DoctorNearby.Business.Models.DTO.Patient;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Business.MappingProfiles
{
    public class PatientMappingProfile : BaseMapperProfile
    {
        public PatientMappingProfile()
        {
            CreateMap<CreatePatientDto,PatientEntity>().ReverseMap();
            CreateMap<PatientDto,PatientEntity>().ReverseMap();
        }
    }
}
