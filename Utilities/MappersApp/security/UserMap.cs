using AutoMapper;
using Entity.Dtos.Security.User;
using Entity.Model.Security;

namespace Utilities.MappersApp.security
{
    public class UserMap : Profile
    {
        public UserMap() 
        { 
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
