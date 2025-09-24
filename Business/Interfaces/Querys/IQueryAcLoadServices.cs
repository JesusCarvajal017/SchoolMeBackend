using Entity.Dtos.Business.AcademicLoad;
using Entity.Model.Business;

namespace Business.Interfaces.Querys
{
    public interface IQueryAcLoadServices : IQueryServices<AcademicLoad, AcademicLoadDto>
    {
        //Task<IEnumerable<UserRolDto>> GetRolsUserServices(int IdUser);
    }
}
