using Entity.Enum;
using Entity.Model.Global;

namespace Entity.Model.Business
{
    public class FamilyRelation : ABaseEntity
    {
        public RelationShipTypeEnum RelationShipType { get; set; }
        public bool Status { get; set; }
        public int StudentsId { get; set; }
        public virtual Student Student { get; set; }
      
    }
}
