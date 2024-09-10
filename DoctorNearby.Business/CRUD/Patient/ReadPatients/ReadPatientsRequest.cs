using DoctorNearby.Business.Models.DTO.Patient;
using DoctorNearby.Core.Models.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Business.CRUD.Patient.ReadPatients
{
    public sealed record ReadPatientsRequest(
        EPatientSortFields PatientSortFields, 
        ESortType SortType,
        int Page,
        int PageSize
    ) : IRequest<BaseResponse<PatientDto>>;

}
