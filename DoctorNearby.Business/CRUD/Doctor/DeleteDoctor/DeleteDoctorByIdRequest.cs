using DoctorNearby.Business.Models.DTO.Doctor;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.DeleteDoctor
{
    public sealed record DeleteDoctorByIdRequest(Guid Id) : IRequest<BaseResponse<DoctorDto>>;

}
