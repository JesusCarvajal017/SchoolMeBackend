using Entity.Dtos.Business.Attendants;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class AttendantsValidation : AbstractValidator<AttendantsDto>
    {
        public AttendantsValidation()
        {
            RuleSet("Full", () =>
            {
                RuleFor(x => x.StudentId)
                    .GreaterThan(0)
                    .WithMessage("El id de la estudiante no es valido.")
                    .NotEmpty().WithMessage("El id de la estudiante es obligatorio");

            });

            // Reglas para PATCH: solo valida si el campo viene presente
            RuleSet("Patch", () =>
            {
                RuleFor(x => x.Id).NotEmpty().WithMessage("El Id es obligatorio");

            });
           
        }


    }
    
}
