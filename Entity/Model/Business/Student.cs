using Entity.Model.Global;
using Entity.Model.Security;
using System.Text.RegularExpressions;

namespace Entity.Model.Business
{
    public class Student : ABaseEntity
    {
        public int PersonId { get; set; }
        public int GroupId { get; set; }
        
        public Person Person { get; set; }
        public ICollection<AgendaDayStudent> AgendaDayStudent { get; set; }
        public ICollection<Attendants> FamilyRelation { get; set; }
        public ICollection<Attendants> Attendants { get; set; }
        public Group Group { get; set; }

    }
}
