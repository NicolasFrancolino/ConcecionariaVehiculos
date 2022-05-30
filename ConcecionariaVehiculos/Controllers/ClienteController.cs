using ConcecionariaVehiculos.Entities;
using ConcecionariaVehiculos.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcecionariaVehiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public ClienteController(IUnitOfWork context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var entidad = _context.ClienteRepo.GetAll();
            return Ok(entidad);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            _context.ClienteRepo.Insert(cliente);
            _context.Save();
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Cliente cliente, int id)
        {
            try
            {
                _context.ClienteRepo.Update(cliente);
                _context.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var entity = _context.ClienteRepo.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.ClienteRepo.Delete(id);
            _context.Save();

            return Ok();
        }
    }
}

