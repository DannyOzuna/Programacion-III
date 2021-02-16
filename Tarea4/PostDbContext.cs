using Microsoft.EntityFrameworkCore;

namespace Tarea4{
    public class PostDbContext : DbContext{
        public DbSet<Infraccion> Infracciones {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlite("Data Source=Infracciones.db");
            }
        }
    }
}