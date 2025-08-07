using Entity.Dtos.Parameters.DocumentType;
using Entity.Dtos.Security.Form;
using FluentValidation;

namespace Utilities.Helpers.Validations.Parameters
{
    public class DocumentTypeValidation : AbstractValidator<DocumentTypeDto>
    {
        public DocumentTypeValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del documento es obligatorio");
        
     
        }
    }
}
