using AutoMapper;
using Entity.Dtos.Security.Person;
using Entity.Model.Security;

namespace Utilities.MappersApp.security
{
    public class PersonMap : Profile
    {
        public PersonMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Person, PersonDto>().ReverseMap();
        }
    }
}