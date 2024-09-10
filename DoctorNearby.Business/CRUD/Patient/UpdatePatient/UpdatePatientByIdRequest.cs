using DoctorNearby.Business.Models.DTO.Patient;
using MediatR;


namespace DoctorNearby.Business.CRUD.Patient.UpdatePatient
{
    public sealed record UpdatePatientByIdRequest(Guid Id, UpdatePatientDto Patient) : IRequest<BaseResponse<UpdatePatientDto>>;

}
