using ConcecionariaVehiculos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcecionariaVehiculos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Cliente>? Clientes { get; set; }
        public virtual DbSet<Vehiculo>? Vehiculos { get; set; }
        public virtual DbSet<Venta>? Ventas { get; set; }
        public virtual DbSet<Usuarios>? Usuario { get; set; }
    }
}
