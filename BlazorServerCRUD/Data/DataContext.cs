using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game()
                {
                    Id = 1,
                    Name = "Half Life 2",
                    Developer = "Valve",
                    Release = new DateTime(2004, 11, 16)
                },
                new Game()
                {
                    Id = 2,
                    Name = "Armored Core",
                    Developer = "FromSoftware",
                    Release = new DateTime(1997, 7, 10)
                }
            );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
