using Entity.Dtos.Global;

namespace Entity.Dtos.Business.AcademicLoad
{
    public class AcademicLoadReadDto : ABaseDto
    {
        public int? TeacherId { get; set; }
        public int? SubjectId { get; set; }
        public int? GroupId { get; set; }

        //public int Day
        public string[] Days { get; set; } = [];
    }
}
