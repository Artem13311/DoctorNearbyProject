using FluentValidation;


namespace DoctorNearby.Business.CRUD.Doctor.CreateDoctor
{
    public sealed class CreateDoctorValidator : AbstractValidator<CreateDoctorRequest>
    {
        public CreateDoctorValidator()
        {
            RuleFor(x=>x.Doctor.FullName).NotEmpty().WithMessage("Doctor full name is required.");
            RuleFor(x => x.Doctor.Cabinet.Number)
            .NotEmpty().WithMessage("Cabinet number is required.")
            .GreaterThan(0).WithMessage("Number of cabinet must be greater than 0.")
            .LessThan(3000).WithMessage("Number of cabinet must be less than 3000.");

            RuleFor(x => x.Doctor.Specialization.Name)
            .NotEmpty().WithMessage("Doctor specialization is required")
            .MinimumLength(3).MaximumLength(50);

        }


    }
}
