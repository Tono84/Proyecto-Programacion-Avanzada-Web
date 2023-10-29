using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Nutriente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdNutriente { get; set; }

    [Required]
    [StringLength(255)]
    public string Nombre { get; set; }

    [Required]
    [StringLength(255)]
    public string Descripcion { get; set; }

}
