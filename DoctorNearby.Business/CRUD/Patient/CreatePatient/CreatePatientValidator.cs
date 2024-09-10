

using FluentValidation;

namespace DoctorNearby.Business.CRUD.Patient.CreatePatient
{
    public class CreatePatientValidator :AbstractValidator<CreatePatientRequest>
    {
        public CreatePatientValidator()
        {
            RuleFor(x=>x.Patient.Address).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Patient.Surname).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Patient.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Patient.Patronymic).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Patient.Birthday).NotEmpty();
            RuleFor(x=>x.Patient.District.Number).NotEmpty().GreaterThan(0).LessThan(1000);


        }
    }
}
