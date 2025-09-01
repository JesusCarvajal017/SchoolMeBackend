using Entity.Dtos.Business.QuestionOption;
using Entity.Dtos.Business.Student;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class StudentsValidation : AbstractValidator<StudentDto>
    {
        public StudentsValidation()
        {
            RuleFor(x => x.GroupId)
              .GreaterThan(0)
               .WithMessage("El id de grupo no es valido.")
                .NotEmpty().WithMessage("El id de grupo es obligatorio");
        }


    }
    
}
