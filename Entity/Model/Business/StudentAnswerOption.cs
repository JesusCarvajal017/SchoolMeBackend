using Entity.Model.Global;

namespace Entity.Model.Business
{
    public class StudentAnswerOption : ABaseEntity
    {
        public long StudentAnswerId { get; set; }
        public long QuestionOptionId { get; set; }

        public virtual StudentAnswer StudentAnswer { get; set; } = null!;
        public virtual QuestionOption QuestionOption { get; set; } = null!;

    }
}
