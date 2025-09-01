using Entity.Dtos.Business.Agenda;
using FluentValidation;
using Utilities.Helpers.Validations.ValidationsGenerics;

namespace Utilities.Helpers.Validations.Business
{
    public class AgendaValidation : AbstractValidator<AgendaDto>
    {
        public AgendaValidation()
        {

            RuleFor(x => x.Name).StandardName(min: 4, max: 20);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
        }


    }
    
}
