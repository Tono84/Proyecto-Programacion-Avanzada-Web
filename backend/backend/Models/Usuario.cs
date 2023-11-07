using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(255)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(255)]
        public string Contraseña { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(255)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(255)]
        public string Correo { get; set; }
    }
}
