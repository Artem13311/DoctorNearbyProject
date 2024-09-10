using DoctorNearby.Business.Models.DTO.Patient;
using MediatR;


namespace DoctorNearby.Business.CRUD.Patient.DeletePatient
{
    public sealed record DeletePatientByIdRequest(Guid Id):IRequest<BaseResponse<PatientDto>>;
    
}
