using Entity.Dtos.Security.Rol;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class RolValidator : AbstractValidator<RolDto>
    {
        public RolValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del rol es obligatorio");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
