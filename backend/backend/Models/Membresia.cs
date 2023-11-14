using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Membresia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMembresia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public DateTime FechaRenovacion { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaPago { get; set; }
        public int IdTipoMembresia { get; set; }
        public int IdUsuario { get; set; }

    }
}
