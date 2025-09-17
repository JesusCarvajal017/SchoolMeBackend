using Entity.Dtos.Especific.Security;
using Entity.Model.Security;
using System.Security.Policy;

namespace Data.Interfaces.Group.Commands
{
    public interface ICommandUser : ICommands<User>
    {
        Task<bool> UpdatePassword(ChangePassword current);
    }
}
