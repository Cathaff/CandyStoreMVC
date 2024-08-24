using Microsoft.EntityFrameworkCore;
using CandyStore.Entity;

namespace CandyStore.DbContexts
{
    public class CandyStoreDbContext : DbContext
    {
        public DbSet<Candy> Candies { get; set;}

        public CandyStoreDbContext(DbContextOptions<CandyStoreDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candy>()
                .HasData(
                new Candy()
                {
                    Id = 1,
                    Name = "Chocolate",
                    Color = "Brown"
                },
                new Candy()
                {
                    Id = 2,
                    Name = "Fizzy Pop",
                    Color = "Pink/Blue"
                },
                new Candy()
                {
                    Id = 3,
                    Name = "Werthes's Original",
                    Color = "Beige"
                },
                new Candy()
                {
                    Id = 4,
                    Name = "Ferrari",
                    Color = "Red"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
