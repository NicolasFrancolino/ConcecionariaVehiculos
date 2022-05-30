using ConcecionariaVehiculos.Data;
using ConcecionariaVehiculos.Entities;

namespace ConcecionariaVehiculos.Repository.Class
{
    public class VentaRepo : GenericRepository<Venta>, IVentasRepo
    {
        public VentaRepo(ApplicationDBContext context) : base(context)
        {
        }
    }
}
