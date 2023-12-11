namespace frontend.Models
{
    public class Membresia
    {
        public int MembresiaID { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int DuracionMeses { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
