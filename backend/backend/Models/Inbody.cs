using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Inbody
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInbody { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCarga { get; set; }
        public string ComentariosProfesional { get; set; }
        public string DocumentoInbody { get; set; }

    }
}
