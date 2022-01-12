using Microsoft.AspNetCore.Mvc;
using MyHealth.ModelContracts;
using MyHealth.ServiceContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T, TService> : ControllerBase
        where T : class, IBaseModel
        where TService : IGenericService<T>
    {
        private readonly TService _service;

        public GenericController(TService service)
        {
            _service = service;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            return await _service.ReadAllAsync();
        }

        // GET: api/[controller]/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(int id)
        {
            var entity = await _service.ReadAsync(id);
            return Ok(entity);
        }

        // PUT: api/[controller]/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, T entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _service.UpdateAsync(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<T>> Post(T entity)
        {
            await _service.CreateAsync(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }


        // DELETE: api/[controller]/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> Delete(int id)
        {
            _ = await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
