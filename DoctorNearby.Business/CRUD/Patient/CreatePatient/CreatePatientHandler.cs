using AutoMapper;
using DoctorNearby.Business.Models.DTO.Patient;
using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using MediatR;


namespace DoctorNearby.Business.CRUD.Patient.CreatePatient
{
    public class CreatePatientHandler : IRequestHandler<CreatePatientRequest, BaseResponse<CreatePatientDto>>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;
        public CreatePatientHandler(IPatientRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<CreatePatientDto>> Handle(CreatePatientRequest request, CancellationToken cancellationToken)
        {
            var patientEntity = _mapper.Map<PatientEntity>(request.Patient);

            await _repository.CreateAsync(patientEntity);

            return new BaseResponse<CreatePatientDto>("The patient was successfully created", 201);

        }
    }
}
