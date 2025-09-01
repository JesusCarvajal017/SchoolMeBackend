using AutoMapper;
using Entity.Dtos.Business.QuestionOption;
using Entity.Dtos.Business.Student;
using Entity.Model.Business;

namespace Utilities.MappersApp.Business
{
    public class StudentMap : Profile
    {
        public StudentMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}