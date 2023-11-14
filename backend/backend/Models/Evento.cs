using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public TimeSpan HoraEvento { get; set; }

    }
}
