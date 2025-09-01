using Entity.Dtos.Business.QuestionOption;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class QuestionOptionValidation : AbstractValidator<QuestionOptionDto>
    {
        public QuestionOptionValidation()
        {
            RuleFor(x => x.Text)
           .NotEmpty().WithMessage("El enunciado del la pregunta es obligatorio");
            
            
        }


    }
    
}
