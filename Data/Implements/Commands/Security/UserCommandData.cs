using Data.Interfaces.Group.Commands;
using Entity.Context.Main;
using Entity.Model.Security;
using Microsoft.Extensions.Logging;
using Utilities.helpers;

namespace Data.Implements.Commands.Security
{
    public class UserCommandData : BaseGenericCommandsData<User> , ICommandUser
    {
        protected readonly ILogger<UserCommandData> _logger;
        protected readonly AplicationDbContext _context;

        public UserCommandData(AplicationDbContext context, ILogger<UserCommandData> logger) : base(context, logger)
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

        // <summary>
        //  Metodo sobreescrito, para poder agregarle la encriptacion de contraseña
        // </summary>
        public override async Task<bool> UpdateAsync(User entity)
        {
            try
            {
                entity.UpdatedAt = DateTime.UtcNow;

                // encriptacion de la contraseña
                entity.Password = HashPassword.EncriptPassword(entity.Password);
                _context.Set<User>().Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) {
                _logger.LogError(ex, $"Actalizando de usuario denegado:  {entity}");
                throw;

            }

        }

    }
}
