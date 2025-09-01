using Entity.Dtos.Business.AgendaDay;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class AgendaDayValidation : AbstractValidator<AgendaDayDto>
    {
        public AgendaDayValidation()
        {

            RuleFor(x => x.AgendaId)
              .GreaterThan(0)
               .WithMessage("El id de la agenda no es valido.")
                .NotEmpty().WithMessage("El id de la persona es obligatorio");
        }


    }
    
}
