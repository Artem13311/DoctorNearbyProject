using DoctorNearby.Business.Models.DTO.Doctor;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.CreateDoctor
{
    public sealed record CreateDoctorRequest(
        CreateDoctorDto Doctor
    ):IRequest<BaseResponse<CreateDoctorDto>>;
    
}
