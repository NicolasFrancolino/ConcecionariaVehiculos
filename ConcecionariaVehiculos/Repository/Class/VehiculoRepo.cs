using ConcecionariaVehiculos.Data;
using ConcecionariaVehiculos.Entities;

namespace ConcecionariaVehiculos.Repository.Class
{
    public class VehiculoRepo : GenericRepository<Vehiculo>, IVehiculoRepo
    {
        public VehiculoRepo(ApplicationDBContext context) : base(context)
        {
        }
    }
}
