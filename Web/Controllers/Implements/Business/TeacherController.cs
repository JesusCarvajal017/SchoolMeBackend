using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Business.Student;
using Entity.Dtos.Business.Teacher;
using Entity.Model.Business;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Business
{
    public class TeacherController
       : GenericController<
       Teacher,
       TeacherDto,
       TeacherDto>
    {
        public TeacherController(
            IQueryServices<Teacher, TeacherDto> q,
            ICommandService<Teacher, TeacherDto> c)
          : base(q, c) { }
    }

}
