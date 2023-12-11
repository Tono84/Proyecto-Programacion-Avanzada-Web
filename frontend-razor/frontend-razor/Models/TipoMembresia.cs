using System.ComponentModel.DataAnnotations;

namespace frontend.Models
{
    public class TipoMembresia
    {
        [Key]
        public int IdTipoMembresia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Duracion { get; set; }
    }
}
