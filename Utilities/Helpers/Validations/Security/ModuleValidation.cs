using Entity.Dtos.Security.Form;
using FluentValidation;
using Utilities.Helpers.Validations.ValidationsGenerics;

namespace Utilities.Helpers.Validations.Security
{
    public class ModuleValidation : AbstractValidator<ModuleDto>
    {
        public ModuleValidation()
        {
            RuleFor(x => x.Name).StandardName(min: 4, max: 15);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
