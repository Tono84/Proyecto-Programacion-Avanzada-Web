namespace frontend.Models
{
public class Alimento
{
    public int IdAlimento { get; set; }
    public string Nombre { get; set; }
    public int Carbohidratos { get; set; }
    public int Vegetales { get; set; }
    public int Frutas { get; set; }
    public int Lacteos { get; set; }
    public int Proteinas { get; set; }
    public int Grasas { get; set; }
    public int AlimentosLibres { get; set; }
    public int Agua { get; set; }
    public bool AltoFibra { get; set; }
    public bool AltoAzucar { get; set; }
    public bool AltoGrasa { get; set; }
    public bool AltoSodio { get; set; }
    public bool LibreGluten { get; set; }
    public int IdNutriente { get; set; }
}

}
