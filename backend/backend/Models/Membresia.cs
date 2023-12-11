using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Membresia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MembresiaID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Precio { get; set; }

        [Required]
        public int DuracionMeses { get; set; }

        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
