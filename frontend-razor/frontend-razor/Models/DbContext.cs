using System;
using frontend.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace frontend.Models
{
    public class MenteCuerpoDbContext : DbContext
    {
        public MenteCuerpoDbContext(DbContextOptions<MenteCuerpoDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoMembresia> TipoMembresias { get; set; }
        public DbSet<Membresia> Membresias { get; set; }

    }
}
