using System;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class MenteCuerpoDbContext : DbContext
    {
        public MenteCuerpoDbContext(DbContextOptions<MenteCuerpoDbContext> options) : base(options)
        {
        }

        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Nutriente> Nutrientes { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoRutinas> TipoRutinas { get; set; }
        public DbSet<TipoMembresia> TipoMembresias { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
    }
}
