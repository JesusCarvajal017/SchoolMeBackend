using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Paramters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Querys.Parameters
{
    public class MunicipalityQueryData : BaseGenericQuerysData<Munisipality> , IQuerysMunicipality
    {
        protected readonly ILogger<MunicipalityQueryData> _logger;
        protected readonly AplicationDbContext _context;

        public MunicipalityQueryData(AplicationDbContext context, ILogger<MunicipalityQueryData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public virtual async Task<IEnumerable<Munisipality>> QueryMunicpalitysDepartaments(int departementId)
        {
            try
            {
                var query = await _context.Munisipality
                    .AsNoTracking()
                    .Where(e => e.DepartamentId == departementId)
                    .ToListAsync();

                return query;

            }
            catch (Exception ex) {

                _logger.LogError(ex, "Error al consultar municipios para el departamento con Id {DepartementId}", departementId);
                return Enumerable.Empty<Munisipality>();
            }
        }
  



    }
}
