using Entity.Dtos.Business.Attendants;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class AttendantsValidation : AbstractValidator<AttendantsDto>
    {
        public AttendantsValidation()
        {

            RuleFor(x => x.StudentId)
              .GreaterThan(0)
               .WithMessage("El id de la estudiante no es valido.")
                .NotEmpty().WithMessage("El id de la estudiante es obligatorio");
        }


    }
    
}
