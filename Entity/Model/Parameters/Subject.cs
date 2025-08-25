using Entity.Model.Business;
using Entity.Model.Global;

namespace Entity.Model.Paramters
{
    public class Subject : ABaseEntity
    {
        public string Name { get; set; }

        public ICollection<AcademicLoad> AcademicLoads { get; set; }
    }
}
