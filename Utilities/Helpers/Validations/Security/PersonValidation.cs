using Entity.Dtos.Security.Person;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {
            RuleFor(x => x.FisrtName)
           .NotEmpty().WithMessage("El nombre del rol es obligatorio");

            RuleFor(x => x.Identification)
                .NotEmpty().WithMessage("La identificacion es obligatoria");
     
        }
    }
}
