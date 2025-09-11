using Entity.Dtos.Global;
using Entity.Enum;

namespace Entity.Dtos.Business.Attendants
{
    public class AttendantsDto : ABaseDto
    {
        public int? StudentId { get; set; }
        public int? PersonId { get; set; }

        public RelationShipTypeEnum? RelationShipTypeEnum { get; set; }
    }
}
