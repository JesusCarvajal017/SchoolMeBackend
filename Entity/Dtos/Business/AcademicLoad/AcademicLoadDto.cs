using Entity.Dtos.Global;

namespace Entity.Dtos.Business.AcademicLoad
{
    public class AcademicLoadDto : ABaseDto
    {
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public int GroupId { get; set; }

        public DayOfWeek Day { get; set; }
        public TimeSpan Time { get; set; }
    }
}
