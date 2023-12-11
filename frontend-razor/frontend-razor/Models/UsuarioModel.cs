
using System.ComponentModel.DataAnnotations;

namespace frontend.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmPassword { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public Membresia Membresia { get; set; }
    }
}