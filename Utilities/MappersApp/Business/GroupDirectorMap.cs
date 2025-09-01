using AutoMapper;
using Entity.Dtos.Business.GroupDirector;
using Entity.Model.Business;

namespace Utilities.MappersApp.Business
{
    public class GroupDirectorMap : Profile
    {
        public GroupDirectorMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<GroupDirector, GroupDirectorDto>().ReverseMap();
        }
    }
}