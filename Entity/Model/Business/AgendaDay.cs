using Entity.Model.Global;
using Entity.Model.Paramters;

namespace Entity.Model.Business
{
    public class AgendaDayStudent : ABaseEntity
    {
        public long AgendaDayId { get; set; }
        public long StudentsId { get; set; }

        public int State { get; set; }   

        // Navegación
        public virtual AgendaDay AgendaDay { get; set; } = null!;
        public virtual Student Students { get; set; } = null!;
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();

    }
}
