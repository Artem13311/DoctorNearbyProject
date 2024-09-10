using DoctorNearby.Business.Models.DTO.Patient;
using DoctorNearby.Persistence.Interfaces;
using MediatR;

namespace DoctorNearby.Business.CRUD.Patient.UpdatePatient
{
    public sealed class UpdatePatientByIdHandler : IRequestHandler<UpdatePatientByIdRequest, BaseResponse<UpdatePatientDto>>
    {
        private readonly IPatientRepository _repository;
        public UpdatePatientByIdHandler(IPatientRepository repository)
        {
            _repository = repository;
        }
        public async Task<BaseResponse<UpdatePatientDto>> Handle(UpdatePatientByIdRequest request, CancellationToken cancellationToken)
        {
            var patient = await _repository.GetByIdAsync(request.Id, cancellationToken);
            if (patient == null) return new BaseResponse<UpdatePatientDto>("Patient not found", 404);

            patient.Surname = request.Patient.Surname;
            patient.Name = request.Patient.Name;
            patient.Patronymic = request.Patient.Patronymic;
            patient.Birthday= request.Patient.Birthday;
            patient.Address = request.Patient.Address;
            patient.DistrictId = request.Patient.DistrictId;
            patient.Sex = request.Patient.Sex;

            await _repository.UpdateAsync(patient);

            return new BaseResponse<UpdatePatientDto>("Patient has been successfully updated", 200);


        }
    }

}
