using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ejercicio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEjercicio { get; set; }

    [Required]
    [MaxLength(255)]
    public string Nombre { get; set; }

    [Required]
    public int EjSet { get; set; }

    [Required]
    public int Repeticiones { get; set; }

    [Required]
    public int IdRutina { get; set; }
}
