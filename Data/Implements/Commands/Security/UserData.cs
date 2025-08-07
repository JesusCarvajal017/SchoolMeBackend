using Data.Implements.Commands;
using Entity.Context.Main;
using Entity.Model.Security;
using Microsoft.Extensions.Logging;
using Utilities.helpers;

namespace Data.Implements.Security
{
    public class UserData : BaseGenericCommandsData<User> 
    {

        protected readonly ILogger<UserData> _logger;
        protected readonly AplicationDbContext _context;

        public UserData(AplicationDbContext context, ILogger<UserData> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        // <summary>
        //  Metodo sobreescrito, ya que se encripar la contraseña
        // </summary>
        public override async Task<User> InsertAsync(User entity)
        {

            try
            {
                // encriptacion de la contraseña
                entity.Password = HashPassword.EncriptPassword(entity.Password);

                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"registro de usuario denegado:  {entity}");
                throw;
            }

        }
    }
}
