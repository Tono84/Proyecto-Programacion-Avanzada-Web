using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class EjerciciosXUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEjericioU { get; set; }
        public int IdUsuario { get; set; }
        public int IdEjercicio { get; set; }
        public int? IdRutina { get; set; }
        public int Cantidad { get; set; }

    }
}
