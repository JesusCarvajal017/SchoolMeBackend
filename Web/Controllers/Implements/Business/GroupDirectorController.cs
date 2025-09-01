using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Business.GroupDirector;
using Entity.Dtos.Business.Question;
using Entity.Model.Business;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Business
{
    public class GroupDirectorController
       : GenericController<
       GroupDirector,
       GroupDirectorDto,
       GroupDirectorDto>
    {
        public GroupDirectorController(
            IQueryServices<GroupDirector, GroupDirectorDto> q,
            ICommandService<GroupDirector, GroupDirectorDto> c)
          : base(q, c) { }
    }

}
