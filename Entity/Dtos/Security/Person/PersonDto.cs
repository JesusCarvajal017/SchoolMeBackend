using Entity.Dtos.Global;
using Entity.Enum;

namespace Entity.Dtos.Security.Person
{
    public class PersonDto : ABaseDto
    {
        public int DocumentTypeId { get; set; }
        public int Identification { get; set; }
        public string FisrtName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Nation { get; set; }
        public int Phone { get; set; }
        public GenderEmun Gender { get; set; }
    }
}
