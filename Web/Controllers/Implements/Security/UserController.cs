using Business.Interfaces.Querys;
using Entity.Dtos.Security.User;
using Entity.Model.Security;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security 
{
    public class UserController
       : GenericController<
       User,
       UserQueryDto,
       UserDto>
    {
        // en caso de extender el controlador en la parte de commandos

        //protected readonly ICommandUserServices _services;

        public UserController(
            IQueryServices<User, UserQueryDto> q,
            ICommandUserServices c)
          : base(q, c) { }


        [HttpPost]
        //[Authorize]
        public override async Task<IActionResult> Create([FromForm][CustomizeValidator(RuleSet = "Full")] UserDto dto)
        {
            var created = await _cmdSvc.CreateServices(dto);

            var id = created.Id;

            return CreatedAtAction(
                nameof(GetById),
                new { id = id },
              created
            );
        }

    }

}
