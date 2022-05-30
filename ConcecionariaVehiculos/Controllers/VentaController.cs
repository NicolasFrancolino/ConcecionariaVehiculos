using ConcecionariaVehiculos.Entities;
using ConcecionariaVehiculos.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcecionariaVehiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public VentaController(IUnitOfWork context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Venta>> Get()
        {
            var entidad = _context.VentaRepo.GetAll();
            return Ok(entidad);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Venta venta)
        {
            _context.VentaRepo.Insert(venta);
            _context.Save();
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Venta venta, int id)
        {
            try
            {
                _context.VentaRepo.Update(venta);
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
            var entity = _context.VentaRepo.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.VentaRepo.Delete(id);
            _context.Save();

            return Ok();
        }

    }
}
