using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Security.Person;
using Entity.Model.Security;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security
{
    public class PersonController
       : GenericController<
       Person,
       PersonQueryDto,
       PersonDto>
    {
        public PersonController(
            IQueryServices<Person, PersonQueryDto> q,
            ICommandService<Person, PersonDto> c)
          : base(q, c) { }
    }

}
