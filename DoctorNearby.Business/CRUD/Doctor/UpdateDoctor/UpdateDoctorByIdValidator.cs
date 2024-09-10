using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Business.CRUD.Doctor.UpdateDoctor
{
    public class UpdateDoctorByIdValidator : AbstractValidator<UpdateDoctorByIdRequest>
    {
        public UpdateDoctorByIdValidator()
        {
            RuleFor(x => x.DoctorDto.FullName).NotEmpty().WithMessage("Doctor full name is required.");
            RuleFor(x => x.DoctorDto.CabinetId).NotEmpty();
            RuleFor(x => x.DoctorDto.SpecializationId).NotEmpty();

        }
    }
}
