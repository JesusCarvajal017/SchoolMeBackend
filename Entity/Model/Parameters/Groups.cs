using Entity.Model.Business;
using Entity.Model.Global;

namespace Entity.Model.Paramters
{
    public class Groups : ABaseEntity
    {
        public string Name { get; set; }
        public int GradeId { get; set; }
        public int AmountStudents { get; set; }

        // Propiedades de navegación
        public GroupDirector GroupDirector { get; set; }
        public Grade Grade { get; set; }
        public ICollection<AcademicLoad> AcademicLoad { get; set; }
        public ICollection<Student> Student { get; set; }
        public ICollection<Agenda> Agenda { get; set; }
        public ICollection<AgendaDay> AgendaDay { get; set; }
    }
}
