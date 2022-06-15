using ConcecionariaVehiculos.Data;
using Microsoft.Extensions.Options;

using ConcecionariaVehiculos.Entities;
using ConcecionariaVehiculos.Modelo.User;

using WebApi.Authorization;
using WebApi.Helpers;

namespace ConcecionariaVehiculos.Services
{
    public class UserService : IUserService
    {
        private ApplicationDBContext _context;
        private IJwtUtils _jwtUtils;
        private readonly AppSettings _appSettings;

        public UserService(
            ApplicationDBContext context,
            IJwtUtils jwtUtils,
            IOptions<AppSettings> appSettings)
        {
            _context = context;
            _jwtUtils = jwtUtils;
            _appSettings = appSettings.Value;
        }


        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _context.Usuario.SingleOrDefault(x => x.UserName == model.UserName);

            //validate
            //if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            //    throw new AppException("Username or password is incorrect");

            // authentication successful so generate jwt token
            var jwtToken = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponse(user, jwtToken);
        }

        public IEnumerable<Usuarios> GetAll()
        {
            return _context.Usuario;
        }

        public Usuarios GetById(int id)
        {
            var user = _context.Usuario.Find(id);
            if (user == null) throw new KeyNotFoundException("User not found");
            return user;
        }
    }
}