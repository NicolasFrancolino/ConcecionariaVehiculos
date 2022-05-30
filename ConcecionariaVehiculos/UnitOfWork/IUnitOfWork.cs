using ConcecionariaVehiculos.Repository;

namespace ConcecionariaVehiculos.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClientesRepo ClienteRepo { get; }
        IVentasRepo VentaRepo { get; }
        IVehiculoRepo VehiculoRepo { get; }
        void Save();
    }
}
