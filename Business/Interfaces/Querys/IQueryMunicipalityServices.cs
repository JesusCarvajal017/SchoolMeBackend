using Entity.Dtos.Parameters.Group;
using Entity.Model.Paramters;

namespace Business.Interfaces.Querys
{
    public interface IQueryMunicipalityServices : IQueryServices<Munisipality, MunicipalityDto>
    {
        Task<IEnumerable<MunicipalityDto>> GetMunicipalitysDepartament(int IdDepartament);
    }
}
