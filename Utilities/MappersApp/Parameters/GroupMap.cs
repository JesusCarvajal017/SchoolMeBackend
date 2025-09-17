using AutoMapper;
using Entity.Dtos.Parameters.Group;
using Entity.Model.Paramters;

namespace Utilities.MappersApp.Parameters
{
    public class GroupMap : Profile
    {
        public GroupMap()
        {
            CreateMap<Groups, GroupsDto>().ReverseMap();
        }
    }
}