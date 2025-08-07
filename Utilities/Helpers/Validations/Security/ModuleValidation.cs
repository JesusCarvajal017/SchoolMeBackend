using Entity.Dtos.Security.Form;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class ModuleValidation : AbstractValidator<ModuleDto>
    {
        public ModuleValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del modulo es obligatorio");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
