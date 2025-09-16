using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Security.Person;
using Entity.Model.Security;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security
{
    public class PersonController
       : GenericController<
       Person,
       PersonQueryDto,
       PersonDto>
    {

        protected readonly IQueryPersonServices _servicesQuery;

        public PersonController(
            IQueryPersonServices q,
            ICommandService<Person, PersonDto> c)
          : base(q, c) 
        { 
            _servicesQuery = q;
        }

        [HttpGet("data/{personId}")]
        public async Task<IActionResult> GetUserRolsById(int personId)
        {
            var result = await _servicesQuery.GetDataCompleteServices(personId);
            return Ok(result);
        }


    }

}
