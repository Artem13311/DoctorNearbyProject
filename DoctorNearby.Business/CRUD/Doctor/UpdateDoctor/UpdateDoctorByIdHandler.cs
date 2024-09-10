using DoctorNearby.Business.Models.DTO.Doctor;
using DoctorNearby.Persistence.Interfaces;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.UpdateDoctor
{
    public sealed class UpdateDoctorByIdHandler : IRequestHandler<UpdateDoctorByIdRequest, BaseResponse<DoctorDto>>
    {
        private readonly IDoctorRepository _repository;

        public UpdateDoctorByIdHandler(IDoctorRepository repository)
        {
            _repository = repository;
        }


        public async Task<BaseResponse<DoctorDto>> Handle(UpdateDoctorByIdRequest request, CancellationToken cancellationToken)
        {
            var doctor = await _repository.GetByIdAsync(request.Id, cancellationToken);

            if (doctor == null) return new BaseResponse<DoctorDto>("Doctor not found", 404);

            doctor.FullName = request.DoctorDto.FullName;
            doctor.DistrictId= request.DoctorDto.DistrictId;
            doctor.CabinetId = request.DoctorDto.CabinetId;
            doctor.SpecializationId= request.DoctorDto.SpecializationId;

            await _repository.UpdateAsync(doctor);

            return new BaseResponse<DoctorDto>("Doctor has been successfully updated", 200);




        }
    }
}
