using Entity.Dtos.Business.CompositionAgenda;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class CompositionValidation : AbstractValidator<CompositionDto>
    {
        public CompositionValidation()
        {
            RuleFor(x => x.AgendaId)
              .GreaterThan(0)
               .WithMessage("El id de la agenda no es valido.")
                .NotEmpty().WithMessage("El id de la agenda es obligatorio");
        }


    }
    
}
