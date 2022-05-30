using ConcecionariaVehiculos.Data;
using ConcecionariaVehiculos.Entities;

namespace ConcecionariaVehiculos.Repository.Class
{
    public class ClienteRepo : GenericRepository<Cliente>, IClientesRepo
    {
        public ClienteRepo(ApplicationDBContext context) : base(context)
        {
        }
    }
}
