using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class EjerciciosXUsuarioView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEjericioU { get; set; }
        public int idUsuario { get; set; }
        public int idEjercicio { get; set; }
        public int? idRutina { get; set; }
        public int Cantidad { get; set; }
        public string EjercicioNombre { get; set; }
        public int EjSet { get; set; }
        public int Repeticiones { get; set; }
        public string RutinaDescripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int IdTipoRutina { get; set; }
    }
}
