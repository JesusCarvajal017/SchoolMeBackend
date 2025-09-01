using AutoMapper;
using Entity.Dtos.Business.Attendants;
using Entity.Model.Business;

namespace Utilities.MappersApp.Business
{
    public class AttendantsMap : Profile
    {
        public AttendantsMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Attendants, AttendantsDto>().ReverseMap();
        }
    }
}