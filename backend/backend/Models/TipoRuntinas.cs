using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class TipoRutinas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoRutina { get; set; }

        [Required]
        [MaxLength(100)]
        public string TipoRutina { get; set; }

        public bool Active { get; set; }
    }
}
