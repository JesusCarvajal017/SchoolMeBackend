using Entity.Model.Global;
using Entity.Model.Paramters;
using Entity.Model.Security;
using System.Text.RegularExpressions;

namespace Entity.Model.Business
{
    public class Teacher : ABaseEntity
    {
        public int PersonId { get; set; } 


        public virtual Person Person { get; set; }
        public virtual GroupDirector GroupDirector { get; set; }
        public virtual ICollection<AcademicLoad> AcademicLoad { get; set; }

    }
}
