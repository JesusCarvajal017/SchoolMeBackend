using Entity.Dtos.Security.User;
using Entity.Dtos.Security.UserRol;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class UserRolValidation : AbstractValidator<UserRolCreateDtos>
    {
        public UserRolValidation() 
        {
            RuleFor(x => x.UserId)
           .NotEmpty().WithMessage("El id del usuario debe ser obligatorio");

            RuleFor(x => x.RolId)
           .NotEmpty().WithMessage("El id del rol es obligatorio");
        }
    }
}
