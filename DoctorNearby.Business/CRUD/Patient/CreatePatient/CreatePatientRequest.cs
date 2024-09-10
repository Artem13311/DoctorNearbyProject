using DoctorNearby.Business.Models.DTO.Patient;
using MediatR;

namespace DoctorNearby.Business.CRUD.Patient.CreatePatient
{
    public sealed record CreatePatientRequest(CreatePatientDto Patient) : IRequest<BaseResponse<CreatePatientDto>>;
    
}
