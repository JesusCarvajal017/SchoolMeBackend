using Entity.Dtos.Security.RolFormPermission;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class RolFormPermissionCreateValidation : AbstractValidator<RolFormPermissionCreateDto>
    {
        public RolFormPermissionCreateValidation()
        {
            RuleFor(x => x.RolId)
           .NotEmpty().WithMessage("El id del rol es obligatorio");

            RuleFor(x => x.FormId)
                .NotEmpty().WithMessage("El Id form es obligatoria");
     
        }
    }
}
