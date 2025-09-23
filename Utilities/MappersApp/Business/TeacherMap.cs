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

            CreateMap<Teacher, TeacherReadDto>()
                .ForMember(dest=> dest.FullName, opt=> opt.MapFrom(t => $"{t.Person.FisrtName} {t.Person.LastName}" ))
                .ReverseMap();
        }
    }
}