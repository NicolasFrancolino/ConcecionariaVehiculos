using System.ComponentModel.DataAnnotations;

namespace ConcecionariaVehiculos.Entities
{
    public class Usuarios
    {
        
        public int Id { get; set; }
        public string? UserNombre { get; set; }
        public string? Email { get; set; }
    }
}
