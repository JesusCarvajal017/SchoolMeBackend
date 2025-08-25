using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Business.DataBasic;
using Entity.Model.Business;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Business
{
    public class DataBasicController
       : GenericController<
       Estudent,
       DataBasicDto,
       DataBasicDto>
    {
        public DataBasicController(
            IQueryServices<Estudent, DataBasicDto> q,
            ICommandService<Estudent, DataBasicDto> c)
          : base(q, c) { }
    }

}
