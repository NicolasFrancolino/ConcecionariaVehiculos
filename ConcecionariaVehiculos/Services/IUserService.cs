using ConcecionariaVehiculos.Entities;
using ConcecionariaVehiculos.Modelo.User;

namespace ConcecionariaVehiculos.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<Usuarios> GetAll();
        Usuarios GetById(int id);
    }
}
