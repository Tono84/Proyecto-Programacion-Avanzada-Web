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

    }
}
