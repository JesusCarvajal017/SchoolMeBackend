using Entity.Dtos.Global;

namespace Entity.Dtos.Parameters.Group
{
    public class GradeDto : ABaseDto
    {
        public string Name { get; set; }
        public int GradeId { get; set; }
        public int AmountStudents { get; set; }
    }

}
