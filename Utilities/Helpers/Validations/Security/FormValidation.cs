using Entity.Dtos.Security.Form;
using FluentValidation;
using Utilities.Helpers.Validations.ValidationsGenerics;

namespace Utilities.Helpers.Validations.Security
{
    public class DataBasicValidation : AbstractValidator<FormDto>
    {
        public DataBasicValidation()
        {
            RuleFor(x => x.Name).StandardName(min: 4, max: 15);
              

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
