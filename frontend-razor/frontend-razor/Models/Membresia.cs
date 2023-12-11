using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace frontend.Models
{
    public class Membresia
    {
        [Key]
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
