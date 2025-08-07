using AutoMapper;
using Entity.Model.Security;

namespace Utilities.MappersApp.security
{
    public class FormDto : Profile
    {
        public FormDto()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Form, FormDto>().ReverseMap();
        }
    }
}