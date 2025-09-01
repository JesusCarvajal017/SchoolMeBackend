using Entity.Dtos.Business.AcademicLoad;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class AcademicLoadValidation : AbstractValidator<AcademicLoadDto>
    {
        public AcademicLoadValidation()
        {

            RuleFor(x => x.TeacherId)
              .GreaterThan(0)
               .WithMessage("El id del profesor no es valido.")
                .NotEmpty().WithMessage("El id del profesor es obligatorio");
        }


    }
    
}
