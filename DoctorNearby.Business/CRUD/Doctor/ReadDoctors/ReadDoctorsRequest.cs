using DoctorNearby.Business.Models.DTO.Doctor;
using DoctorNearby.Core.Models.Enums;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.ReadDoctors
{
    public sealed record ReadDoctorsRequest(
        EDoctorSortFileds DoctorSortFileds,
        ESortType SortType,
        int Page,
        int PageSize
        ) : IRequest<BaseResponse<DoctorDto>>;
    
}
