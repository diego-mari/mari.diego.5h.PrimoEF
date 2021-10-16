using Microsoft.EntityFrameworkCore;

namespace mari.diego._5h.PrimoEF
{
    public class DbPersone : DbContext
    {
        public DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
            => opzioni.UseSqlite("Data Source=dbPersone.db");
    }
}