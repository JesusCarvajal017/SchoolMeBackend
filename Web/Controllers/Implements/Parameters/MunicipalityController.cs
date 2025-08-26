using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Parameters.Group;
using Entity.Model.Paramters;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Parameters
{
    public class MunicipalityController
       : GenericController<
       Munisipality,
       MunicipalityDto,
       MunicipalityDto>
    {
        public MunicipalityController(
            IQueryServices<Munisipality, MunicipalityDto> q,
            ICommandService<Munisipality, MunicipalityDto> c)
          : base(q, c) { }
    }

}
