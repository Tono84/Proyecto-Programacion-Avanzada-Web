using System;

namespace frontend.Models
{
    public class Historial
    {
        public int idInbody { get; set; }
        public int idUsuario { get; set; }
        public DateTime fechaCarga { get; set; }
        public string comentariosProfesional { get; set; }
        public string documentoInbody { get; set; }
    }
}
