using DoctorNearby.Business.Models.DTO.Doctor;
using DoctorNearby.Persistence.Interfaces;
using MediatR;


namespace DoctorNearby.Business.CRUD.Doctor.DeleteDoctor
{
    internal class DeleteDoctorByIdHandler : IRequestHandler<DeleteDoctorByIdRequest, BaseResponse<DoctorDto>>
    {
        private readonly IDoctorRepository _repository;
        public DeleteDoctorByIdHandler(IDoctorRepository repository)
        {
            _repository = repository;
        }
        public async Task<BaseResponse<DoctorDto>> Handle(DeleteDoctorByIdRequest request, CancellationToken cancellationToken)
        {
            var doctor = await _repository.GetByIdAsync(request.Id, cancellationToken);

            if (doctor == null) return new BaseResponse<DoctorDto>("Doctor not found", 404);

            await _repository.DeleteAsync(doctor);

            return new BaseResponse<DoctorDto>("Doctor was successfully removed", 200);
        }
    }
}
