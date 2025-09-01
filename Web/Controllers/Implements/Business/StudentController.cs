using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Business.Student;
using Entity.Model.Business;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Business
{
    public class StudentController
       : GenericController<
       Student,
       StudentDto,
       StudentDto>
    {
        public StudentController(
            IQueryServices<Student, StudentDto> q,
            ICommandService<Student, StudentDto> c)
          : base(q, c) { }
    }

}
