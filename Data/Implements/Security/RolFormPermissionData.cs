using Data.Implements.Querys;
using Entity.Context.Main;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Security
{
    public class ModuleFormData : BaseGenericQuerysData<ModuleForm> 
    {

        protected readonly ILogger<ModuleFormData> _logger;
        protected readonly AplicationDbContext _context;

        public ModuleFormData(AplicationDbContext context, ILogger<ModuleFormData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public override async Task<IEnumerable<ModuleForm>> QueryAllAsyn()
        {
            try
            {
                var model = await _context.ModuleForm
                                .Include(ur => ur.Form)
                                .Include(ur => ur.Module)
                                .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(ModuleForm).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(ModuleForm).Name);
                throw;
            }
        }

    }
}
