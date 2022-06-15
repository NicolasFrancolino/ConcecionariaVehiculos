using System.ComponentModel.DataAnnotations;

namespace ConcecionariaVehiculos.Modelo.User
{
    public class AuthenticateRequest
    {   
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
