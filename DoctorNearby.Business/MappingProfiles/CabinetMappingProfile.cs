using DoctorNearby.Business.MappingProfiles.Base;
using DoctorNearby.Business.Models.DTO.Cabinet;
using DoctorNearby.Persistence.Models.Entities;


namespace DoctorNearby.Business.MappingProfiles
{
    public class CabinetMappingProfile : BaseMapperProfile
    {
        public CabinetMappingProfile() {

            CreateMap<CommandCabinetDto, CabinetEntity>().ReverseMap();
            CreateMap<CabinetDto, CabinetEntity>().ReverseMap();


        }
    }
}
