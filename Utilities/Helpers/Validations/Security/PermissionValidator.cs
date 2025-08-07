using Entity.Dtos.Security.Permission;
using Entity.Dtos.Security.Rol;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class PermissionValidator : AbstractValidator<PermissionDto>
    {
        public PermissionValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage($"El nombre del permiso es obligatorio");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
