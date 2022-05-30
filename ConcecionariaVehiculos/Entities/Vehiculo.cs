using System.ComponentModel.DataAnnotations;

namespace ConcecionariaVehiculos.Entities
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Marca { get; set; }

        [Required]
        public string? Modelo { get; set; }

        [Required]
        public double Importe { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaBaja { get; set; }
    }
}
