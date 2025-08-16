using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Global;
using Entity.Model.Global;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace Web.Controllers.Implements.Abstract
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class GenericController<
            TEntity,
            TReadDto,
            TWriteDto> 
            : ControllerBase
          where TEntity : ABaseEntity   
          where TReadDto : ABaseDto
          where TWriteDto : ABaseDto
    {
        protected readonly IQueryServices<TEntity, TReadDto> _querySvc;
        protected readonly ICommandService<TEntity, TWriteDto> _cmdSvc;

        protected GenericController(
            IQueryServices<TEntity, TReadDto> querySvc,
            ICommandService<TEntity, TWriteDto> cmdSvc)
        {
            _querySvc = querySvc;
            _cmdSvc = cmdSvc;
        }

        [HttpGet]
        [OutputCache]
        public virtual async Task<IActionResult> GetAll(int? status) => Ok(await _querySvc.GetAllServices(status));

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(int id) => Ok(await _querySvc.GetByIdServices(id));

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromBody] TWriteDto dto)
        {
            var created = await _cmdSvc.CreateServices(dto);

            var id = created.Id;

            return CreatedAtAction(
                nameof(GetById),
                new { id = id },
              created
            );
        }

        [HttpPut]
        public virtual async Task<IActionResult> Update([FromBody] TWriteDto dto) => Ok(await _cmdSvc.UpdateServices(dto));

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id) => Ok(await _cmdSvc.DeleteServices(id));
    }
}