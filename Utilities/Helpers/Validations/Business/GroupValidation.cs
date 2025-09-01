using Entity.Dtos.Business.CompositionAgenda;
using Entity.Dtos.Parameters.Group;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class GroupValidation : AbstractValidator<GroupsDto>
    {
        public GroupValidation()
        {
            RuleFor(x => x.AgendaId)
              .GreaterThan(0)
               .WithMessage("El id de la agenda no es valido.")
                .NotEmpty().WithMessage("El id de la agenda es obligatorio");
        }


    }
    
}
