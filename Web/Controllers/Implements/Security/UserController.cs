using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Security.User;
using Entity.Model.Security;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security 
{
    public class UserController
       : GenericController<
       User,
       UserDto,
       UserDto>
    {
        public UserController(
            IQueryServices<User, UserDto> q,
            ICommandService<User, UserDto> c)
          : base(q, c) { }
    }

}
