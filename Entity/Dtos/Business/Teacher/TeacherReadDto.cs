using Entity.Dtos.Global;

namespace Entity.Dtos.Business.Teacher
{
    public class TeacherReadDto : ABaseDto
    {
        public int? PersonId { get; set; }
        public string? FullName { get; set; }


    }
}
