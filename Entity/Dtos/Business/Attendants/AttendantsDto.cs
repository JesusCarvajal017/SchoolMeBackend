using Entity.Dtos.Global;

namespace Entity.Dtos.Business.Attendants
{
    public class AttendantsDto : ABaseDto
    {
        public int AgendaDayId { get; set; }
        public int StudentsId { get; set; }
        public int AgendaDayStudentStatus { get; set; }
        public DateTime? CompletedAt { get; set; } // cuando completo la agenda de ese estudiante
    }
}
