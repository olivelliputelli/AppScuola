using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace AppScuola.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ClasseStudenti> ClassiStudenti { get; set; } /* VISTA */
        public DbSet<Classe> Classi { get; set; }
        public DbSet<Materia> Materie { get; set; }
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Verifica> Verifiche { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClasseStudenti>()
            .ToView("ClassiStudenti");


       //     modelBuilder.Entity<Verifica>()
       //.HasKey(e => new { e.Data, e.MateriaId, e.Matricola });


        }
    }
}