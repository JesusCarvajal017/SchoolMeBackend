using Entity.Dtos.Security.Form;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class DataBasicValidation : AbstractValidator<FormDto>
    {
        public DataBasicValidation()
        {
            RuleFor(x => x.Name)
              .Cascade(CascadeMode.Stop)
              .NotEmpty().WithMessage("El nombre es obligatorio.")
              .Must(s => !string.IsNullOrWhiteSpace(s))
                  .WithMessage("El nombre no puede ser solo espacios.")
              .Matches(@"^[\p{L}\s'\-]+$") // letras Unicode + espacios + ' y -
                  .WithMessage("El nombre solo puede contener letras y espacios (sin números).")
               .MinimumLength(4).WithMessage("El nombre debe tener al menos 4 caracteres.")
               .MaximumLength(30).WithMessage("El nombre no puede exceder 15 caracteres.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria");
     
        }
    }
}
