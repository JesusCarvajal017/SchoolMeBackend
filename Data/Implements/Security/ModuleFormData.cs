using Data.Implements.Querys;
using Entity.Context.Main;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Security
{
    public class RolFormPermissionData : BaseGenericQuerysData<RolFormPermission> 
    {

        protected readonly ILogger<RolFormPermissionData> _logger;
        protected readonly AplicationDbContext _context;

        public RolFormPermissionData(AplicationDbContext context, ILogger<RolFormPermissionData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public override async Task<IEnumerable<RolFormPermission>> QueryAllAsyn()
        {
            try
            {
                var model = await _context.RolFormPermission
                                .Include(ur => ur.Rol)
                                .Include(ur => ur.Form)
                                .Include(ur => ur.Permission)
                                .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(RolFormPermission).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(RolFormPermission).Name);
                throw;
            }
        }

    }
}
