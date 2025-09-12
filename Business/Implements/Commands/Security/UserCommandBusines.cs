using AutoMapper;
using Business.Implements.Bases;
using Business.Interfaces.Querys;
using Data.Interfaces.Group.Commands;
using Entity.Dtos.Security.User;
using Entity.Model.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Security.Policy;
using Utilities.AlmacenadorArchivos.Interface;
using Utilities.Helpers.Validations;

namespace Business.Implements.Commands.Security
{
    public class UserCommandBusines : BaseCommandsBusiness<User, UserDto>, ICommandUserServices
    {
        protected readonly ICommandUser _data;
        protected readonly IAlmacenadorArchivos _svArchv;
        private readonly string cotenedor = "usuarios";

        public UserCommandBusines(
            ICommandUser data,
            IMapper mapper,
            ILogger<UserCommandBusines> _logger,
            IAlmacenadorArchivos alamacenadorArchivos,
            IGenericHerlpers helpers) : base(data, mapper, _logger, helpers)
        {
            _data = data;
            _svArchv = alamacenadorArchivos;
        }



        /// <summary>
        /// Valida un DTO utilizando las reglas de validación de FluentValidation.
        /// </summary>
        /// <param name="dto">El objeto DTO a validar</param>
        /// <returns>Una tarea que representa la operación de validación asíncrona</returns>
        /// <remarks>
        /// Este método utiliza el servicio _helpers para realizar la validación.
        /// Si la validación falla, se agrupan todos los errores en una sola excepción.
        /// </remarks>
        protected async Task EnsureValid(UserDto dto)
        {
            var validationResult = await _helpers.Validate(dto);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors);
                throw new ArgumentException($"Validación fallida: {errors}");
            }
        }

        /// <summary>
        /// Crea una nueva entidad en el sistema a partir de un DTO.
        /// </summary>
        /// <param name="dto">El DTO que contiene los datos para crear la nueva entidad</param>
        /// <returns>
        /// El DTO de la entidad creada, incluyendo el ID asignado y cualquier otro campo generado
        /// </returns>
        /// <exception cref="Exception">
        /// Se relanza cualquier excepción que ocurra durante la operación de creación
        /// </exception>
        /// <remarks>
        /// Este método:
        /// 1. Valida el DTO de entrada
        /// 2. Lo mapea a una entidad
        /// 3. Crea la entidad en el repositorio
        /// 4. Mapea la entidad creada de vuelta a DTO y la retorna
        /// 5. Registra la operación y maneja errores
        /// </remarks>
        public override async Task<UserDto> CreateServices(UserDto dto)
        {
            try
            {
                // validacion de dto
                await EnsureValid(dto);
                var entity = _mapper.Map<User>(dto);

                if(dto.Photo is not null)
                {
                    //Url de la nube o otro servicio
                    var url = await _svArchv.Almacenar(cotenedor, dto.Photo);
                    entity.Photo = url;
                }


                entity = await _data.InsertAsync(entity);
                _logger.LogInformation($"Creando nuevo {typeof(User).Name}");
                return _mapper.Map<UserDto>(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear {typeof(User).Name} desde DTO: {ex.Message}");
                throw;
            }
        }




    }
}
