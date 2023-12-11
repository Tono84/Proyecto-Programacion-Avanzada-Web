namespace frontend.Models
{
    public class EjercicioXUsuario
{
        public int IdEjericioU { get; set; }
        public int IdUsuario { get; set; }
        public int IdEjercicio { get; set; }
        public int? IdRutina { get; set; }
        public int Cantidad { get; set; }
        public string EjercicioNombre { get; set; }
        public int EjSet { get; set; }
        public int Repeticiones { get; set; }
        public string RutinaDescripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int IdTipoRutina { get; set; }
    }
}
