using DoctorNearby.Business.MappingProfiles.Base;
using DoctorNearby.Business.Models.DTO.District;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Business.MappingProfiles
{
    public class DistrictMapperProfile : BaseMapperProfile
    {
        public DistrictMapperProfile()
        {
            CreateMap<CommandDistrictDto, DistrictEntity>().ReverseMap();
            CreateMap<DistrictDto, DistrictEntity>().ReverseMap();

        }
    }
}
