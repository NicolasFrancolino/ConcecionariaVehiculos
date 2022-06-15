using ConcecionariaVehiculos.Entities;

namespace ConcecionariaVehiculos.Modelo.User
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(Usuarios user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Role = user.Role;
            Token = token;
        }
    }
}
