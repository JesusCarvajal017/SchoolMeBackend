using AutoMapper;
using Entity.Dtos.Security.User;
using Entity.Model.Security;

namespace Utilities.MappersApp.security
{
    public class UserMap : Profile
    {
        public UserMap() 
        {
            // map de commandos
            CreateMap<User, UserDto>()
                .ForMember(x => x.Photo, op => op.Ignore()).ReverseMap();

            // consulta principal
            CreateMap<User, UserQueryDto>().ReverseMap();
        }
    }
}
