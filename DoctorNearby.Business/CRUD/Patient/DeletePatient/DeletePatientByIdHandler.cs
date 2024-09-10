using DoctorNearby.Business.Models.DTO.Patient;
using DoctorNearby.Persistence.Interfaces;
using MediatR;

namespace DoctorNearby.Business.CRUD.Patient.DeletePatient
{
    public sealed class DeletePatientByIdHandler : IRequestHandler<DeletePatientByIdRequest,BaseResponse<PatientDto>>
    {
        private readonly IPatientRepository _repository;

        public DeletePatientByIdHandler(IPatientRepository repository)
        {
            _repository = repository;
        }

        public async Task<BaseResponse<PatientDto>> Handle(DeletePatientByIdRequest request, CancellationToken cancellationToken)
        {
            var patient = await _repository.GetByIdAsync(request.Id, cancellationToken);

            if (patient == null) return new BaseResponse<PatientDto>("Patient not found", 404);

            await _repository.DeleteAsync(patient);

            return new BaseResponse<PatientDto>("Patient was successfully removed", 200);
        }
    }
}
