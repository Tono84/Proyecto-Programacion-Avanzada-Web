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
        public DbSet<Rutina> Rutina { get; set; }
        public DbSet<EjerciciosXUsuario> EjerciciosXUsuario { get; set; }
        public DbSet<Error> Errores { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Inbody> Inbody { get; set; }
        public DbSet<Inbox> Inbox { get; set; }
        public DbSet<Membresia> Membresias { get; set; }

        public DbSet<EjerciciosXUsuarioView> EjerciciosXUsuarioView { get; set; }

    }
}
