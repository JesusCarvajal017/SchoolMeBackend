using Entity.Dtos.Business.AgendaDayStudent;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class AgendaDayStudentValidation : AbstractValidator<AgendaDayStudentDto>
    {
        public AgendaDayStudentValidation()
        {

            RuleFor(x => x.AgendaDayId)
              .GreaterThan(0)
               .WithMessage("El id de la agenda day no es valido.")
                .NotEmpty().WithMessage("El id de la persona es obligatorio");
        }


    }
    
}
