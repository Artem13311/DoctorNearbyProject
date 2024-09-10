using AutoMapper;
using DoctorNearby.Business.Models.DTO.Doctor;
using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.CreateDoctor
{
    public sealed class CreateDoctorHandler : IRequestHandler<CreateDoctorRequest, BaseResponse<CreateDoctorDto>>
    {
        private readonly IMapper _mapper;
        private readonly IDoctorRepository _repository;

        public CreateDoctorHandler(IMapper mapper, IDoctorRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<BaseResponse<CreateDoctorDto>> Handle(CreateDoctorRequest request, CancellationToken cancellationToken)
        {
            var doctorEntity = _mapper.Map<DoctorEntity>(request.Doctor);

            await _repository.CreateAsync(doctorEntity);

            return new BaseResponse<CreateDoctorDto>("The doctor was successfully created", 201);

        }
    }
}
