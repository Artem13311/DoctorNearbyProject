using DoctorNearby.Business.MappingProfiles.Base;
using DoctorNearby.Business.Models.DTO.Doctor;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Business.MappingProfiles
{
    public class DoctorMappingProfile : BaseMapperProfile
    {
        public DoctorMappingProfile()
        {
            CreateMap<CreateDoctorDto, DoctorEntity>().ReverseMap();
            CreateMap<DoctorDto, DoctorEntity>().ReverseMap();


        }
    }
}
