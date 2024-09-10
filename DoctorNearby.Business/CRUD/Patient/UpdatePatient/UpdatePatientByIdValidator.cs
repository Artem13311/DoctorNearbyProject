using FluentValidation;


namespace DoctorNearby.Business.CRUD.Patient.UpdatePatient
{
    public class UpdatePatientByIdValidator : AbstractValidator<UpdatePatientByIdRequest>
    {
        public UpdatePatientByIdValidator()
        {
            RuleFor(x => x.Patient.Address).NotEmpty();
            RuleFor(x => x.Patient.Birthday).NotEmpty();
            RuleFor(x => x.Patient.Name).NotEmpty();
            RuleFor(x => x.Patient.Surname).NotEmpty();
            RuleFor(x => x.Patient.Patronymic).NotEmpty();
            RuleFor(x => x.Patient.DistrictId).NotEmpty();

        }
    }
}
