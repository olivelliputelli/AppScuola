using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppScuola.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ClasseStudenti> ClassiStudenti { get; set; } /* VISTA */
        public DbSet<Classe> Classi { get; set; }
        public DbSet<Studente> Studenti { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClasseStudenti>()
                .ToView("ClassiStudenti");
        }
    }
}