using ConcecionariaVehiculos.Entities;
using ConcecionariaVehiculos.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcecionariaVehiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public VehiculoController(IUnitOfWork context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vehiculo>> Get()
        {
            var entidad = _context.VehiculoRepo.GetAll();
            return Ok(entidad);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Vehiculo vehiculo)
        {
            _context.VehiculoRepo.Insert(vehiculo);
            _context.Save();
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Vehiculo vehiculo, int id)
        {
            try
            {
                _context.VehiculoRepo.Update(vehiculo);
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
            var entity = _context.VehiculoRepo.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.VehiculoRepo.Delete(id);
            _context.Save();

            return Ok();
        }
    }
}
