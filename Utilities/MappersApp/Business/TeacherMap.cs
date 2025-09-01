using AutoMapper;
using Entity.Dtos.Business.Teacher;
using Entity.Model.Business;

namespace Utilities.MappersApp.Business
{
    public class TeacherMap : Profile
    {
        public TeacherMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Teacher, TeacherDto>().ReverseMap();
        }
    }
}