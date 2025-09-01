using Entity.Dtos.Business.Question;
using FluentValidation;

namespace Utilities.Helpers.Validations.Business
{
    public class QuestionValidation : AbstractValidator<QuestionDto>
    {
        public QuestionValidation()
        {
            RuleFor(x => x.Text)
           .NotEmpty().WithMessage("El enunciado del la pregunta es obligatorio");
            
            
        }


    }
    
}
