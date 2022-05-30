using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcecionariaVehiculos.Entities
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Importe { get; set; }

        public double Descuento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [ForeignKey("Vehiculo")]
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
