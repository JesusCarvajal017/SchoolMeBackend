using Entity.Model.Global;
using Entity.Model.Paramters;
using Entity.Model.Security;
using System.Text.RegularExpressions;

namespace Entity.Model.Business
{
    public class Student : ABaseEntity
    {
        public int TutionId { get; set; }
        public int PersonId { get; set; }
        public int GroupId { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<FamilyRelation> FamilyRelation { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<AgendaDayStudent> AgendaDayStudent { get; set; }

    }
}
