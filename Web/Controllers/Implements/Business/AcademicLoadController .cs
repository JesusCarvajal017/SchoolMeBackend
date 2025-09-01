using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Business.AcademicLoad;
using Entity.Dtos.Business.DataBasic;
using Entity.Model.Business;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Business
{
    public class AcademicLoadController
       : GenericController<
       AcademicLoad,
       AcademicLoadDto,
       AcademicLoadDto>
    {
        public AcademicLoadController(
            IQueryServices<AcademicLoad, AcademicLoadDto> q,
            ICommandService<AcademicLoad, AcademicLoadDto> c)
          : base(q, c) { }
    }

}
