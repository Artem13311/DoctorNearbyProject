using DoctorNearby.Business.Models.DTO.Doctor;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.UpdateDoctor
{
    public sealed record UpdateDoctorByIdRequest(Guid Id,UpdateDoctorDto DoctorDto) : IRequest<BaseResponse<DoctorDto>>;
  
}
