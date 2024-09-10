using AutoMapper;
using DoctorNearby.Business.Models.DTO.Patient;
using DoctorNearby.Persistence.Interfaces;
using MediatR;


namespace DoctorNearby.Business.CRUD.Patient.ReadPatients
{
    public sealed class ReadPatientsHandler : IRequestHandler<ReadPatientsRequest, BaseResponse<PatientDto>>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;
        public ReadPatientsHandler(IPatientRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<PatientDto>> Handle(ReadPatientsRequest request, CancellationToken cancellationToken)
        {
            var patientsByPage = await _repository.GetByPage(request.Page, request.PageSize);

            var sortedPatients = await _repository.GetAllWithFilterAsync(patientsByPage, request.PatientSortFields, request.SortType);

            return sortedPatients.Count == 0
                ? new BaseResponse<PatientDto>("No patients found with this filter", 404)
                : new BaseResponse<PatientDto>(_mapper.Map<List<PatientDto>>(sortedPatients));
        }
    }
}
