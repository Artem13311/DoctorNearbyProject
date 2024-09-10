

using AutoMapper;
using DoctorNearby.Business.Models.DTO.Doctor;
using DoctorNearby.Persistence.Interfaces;
using MediatR;

namespace DoctorNearby.Business.CRUD.Doctor.ReadDoctors
{
    public sealed class ReadDoctorsHandler : IRequestHandler<ReadDoctorsRequest, BaseResponse<DoctorDto>>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;
        public ReadDoctorsHandler(IDoctorRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<BaseResponse<DoctorDto>> Handle(ReadDoctorsRequest request, CancellationToken cancellationToken)
        {
            var doctorsByPage = await _repository.GetByPage(request.Page, request.PageSize);

            var sortedDoctors = await _repository.GetAllWithFilterAsync(doctorsByPage, request.DoctorSortFileds,request.SortType, cancellationToken);
            
            return sortedDoctors.Count == 0
               ? new BaseResponse<DoctorDto>("No doctors found with that filter", 404)
               : new BaseResponse<DoctorDto>(_mapper.Map<List<DoctorDto>>(sortedDoctors));
    
        }
    }
}
