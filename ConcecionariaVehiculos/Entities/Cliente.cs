using System.ComponentModel.DataAnnotations;

namespace ConcecionariaVehiculos.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }

        [Required]
        public string? DNI { get; set; }

        [Required]
        public string? Direccion { get; set; }
    }
}
