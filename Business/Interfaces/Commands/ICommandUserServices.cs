using Business.Interfaces.Commands;
using Entity.Dtos.Security.User;
using Entity.Model.Security;

namespace Business.Interfaces.Querys
{
    public interface ICommandUserServices : ICommandService<User, UserDto>
    {
        //Task<IEnumerable<UserRolDto>> GetRolsUserServices(int IdUser);
    }
}
