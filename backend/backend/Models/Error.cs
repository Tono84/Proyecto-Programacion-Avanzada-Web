using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdError { get; set; }
        public int IdUsuario { get; set; }
        public string MensajeError { get; set; }
        public DateTime FechaError { get; set; }
        public TimeSpan HoraError { get; set; }

    }
}
