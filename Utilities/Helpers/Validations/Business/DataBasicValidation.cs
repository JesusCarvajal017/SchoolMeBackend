using Entity.Model.Business;
using FluentValidation;

namespace Utilities.Helpers.Business
{
    public class DataBasicValidation : AbstractValidator<DataBasic>
    {
        public DataBasicValidation()
        {
            RuleFor(x => x.PersonId)
           .NotEmpty().WithMessage("El id de la persona es obligatorio");
        }
    }
}
