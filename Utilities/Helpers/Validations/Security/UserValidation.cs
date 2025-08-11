using Entity.Dtos.Security.User;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class UserValidation : AbstractValidator<UserDto>
    {
        public UserValidation() 
        {
            RuleFor(x => x.PersonId)
           .NotEmpty().WithMessage("El id de la persona es obligatorio");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("El correo es obligatorio")
                .EmailAddress().WithMessage("Formato de correo inválido");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria")
                .MinimumLength(6).WithMessage("Debe tener al menos 6 caracteres"); 
        }
    }
}
