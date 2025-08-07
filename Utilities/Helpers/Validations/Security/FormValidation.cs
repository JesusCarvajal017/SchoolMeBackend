using Entity.Dtos.Security.Form;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class DataBasicValidation : AbstractValidator<FormDto>
    {
        public DataBasicValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del formulario es obligatorio");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
