using Entity.Model.Global;

namespace Entity.Model.Business
{
    public class StudentAnswerOption : ABaseEntity
    {
        // FKs
        public long StudentAnswerId { get; set; }
        public long QuestionOptionId { get; set; }

        // Navegación
        public virtual StudentAnswer StudentAnswer { get; set; } = null!;
        public virtual QuestionOption QuestionOption { get; set; } = null!;

    }
}
