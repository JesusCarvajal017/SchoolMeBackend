using Entity.Dtos.Security.ModuleForm;
using FluentValidation;

namespace Utilities.Helpers.Validations.Security
{
    public class ModuleFormValidation : AbstractValidator<ModuleFormCreation>
    {
        public ModuleFormValidation()
        {
            RuleFor(x => x.ModuleId)
           .NotEmpty().WithMessage("El id del modulo es obligatorio");

            RuleFor(x => x.FormId)
                .NotEmpty().WithMessage("El Id form es obligatoria");
     
        }
    }
}
