using Entity.Dtos.Business.StudentAnswareOption;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class StudentsAnswareOptionValidation : AbstractValidator<StudentAnswareOptionDto>
    {
        public StudentsAnswareOptionValidation()
        {
            RuleFor(x => x.StudentAnswerId)
              .GreaterThan(0)
              .GreaterThan(0)
               .WithMessage("El id de grupo no es valido.")
                .NotEmpty().WithMessage("El id de grupo es obligatorio");
        }


    }
    
}
