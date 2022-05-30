using ConcecionariaVehiculos.Data;
using ConcecionariaVehiculos.Repository;
using ConcecionariaVehiculos.Repository.Class;

namespace ConcecionariaVehiculos.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public IClientesRepo ClienteRepo { get; private set; }

        public IVentasRepo VentaRepo { get; private set; }

        public IVehiculoRepo VehiculoRepo { get; private set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            ClienteRepo = new ClienteRepo(context);
            VentaRepo = new VentaRepo(context);
            VehiculoRepo = new VehiculoRepo(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
