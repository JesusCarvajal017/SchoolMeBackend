using Entity.Dtos.Parameters.Grade;
using FluentValidation;
using Utilities.Helpers.Validations.ValidationsGenerics;

namespace Utilities.Helpers.Validations.Parameters
{
    public class GradeValidation : AbstractValidator<GradeDto>
    {
        public GradeValidation()
        {
            RuleFor(x => x.Name).StandardName(min: 4, max: 20);


        }
    }
}
