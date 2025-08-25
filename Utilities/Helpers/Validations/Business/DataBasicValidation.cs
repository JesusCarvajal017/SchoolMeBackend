using Entity.Model.Business;
using FluentValidation;

namespace Utilities.Helpers.Business
{
    public class DataBasicValidation : AbstractValidator<Estudent>
    {
        public DataBasicValidation()
        {
            RuleFor(x => x.PersonId)
           .NotEmpty().WithMessage("El id de la persona es obligatorio");
        }
    }
}
