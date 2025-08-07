using AutoMapper;
using Entity.Dtos.Security.UserRol;
using Entity.Model.Security;

namespace Utilities.MappersApp.security
{
    public class RolUserMap : Profile
    {
        public RolUserMap()
        {
            CreateMap <UserRol, UserRolDto>().ReverseMap();
            CreateMap<UserRol, UserRolCreateDtos>().ReverseMap();
        } 
   
    }
}
