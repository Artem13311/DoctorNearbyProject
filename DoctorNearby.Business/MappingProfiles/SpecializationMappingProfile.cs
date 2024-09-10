using DoctorNearby.Business.MappingProfiles.Base;
using DoctorNearby.Business.Models.DTO.Specialization;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Business.MappingProfiles
{
    public class SpecializationMappingProfile : BaseMapperProfile
    {
        public SpecializationMappingProfile()
        {
            CreateMap<CommandSpecializationDto, SpecializationEntity>().ReverseMap();
            CreateMap<SpecializationDto, SpecializationEntity>().ReverseMap();

        }
    }
}
