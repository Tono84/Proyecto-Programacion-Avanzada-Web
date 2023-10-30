using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Alimento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdAlimento { get; set; }

    [Required]
    [StringLength(255)]
    public string Nombre { get; set; }

    [Required]
    public int Carbohidratos { get; set; }

    [Required]
    public int Vegetales { get; set; }

    [Required]
    public int Frutas { get; set; }

    [Required]
    public int Lacteos { get; set; }

    [Required]
    public int Proteinas { get; set; }

    [Required]
    public int Grasas { get; set; }

    [Required]
    public int AlimentosLibres { get; set; }

    [Required]
    public int Agua { get; set; }

    [Required]
    public bool AltoFibra { get; set; }

    [Required]
    public bool AltoAzucar { get; set; }

    [Required]
    public bool AltoGrasa { get; set; }

    [Required]
    public bool AltoSodio { get; set; }

    [Required]
    public bool LibreGluten { get; set; }

    [Required]
    public int IdNutriente { get; set; }

}
