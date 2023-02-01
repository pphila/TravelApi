using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Destination2> Destinations2 { get; set; }
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Destination>()
                .HasData(
                    new Destination { DestinationId = 1, City = "Seattle", Country = "USA", Rating = 5 , Review = "Good coffee, scenic bay, awesome market"},
                    new Destination { DestinationId = 2, City = "Paris", Country = "France", Rating = 4, Review = "Bon bageutte"},
                    new Destination { DestinationId = 3, City = "Tokyo", Country = "Japan", Rating = 5, Review = "So many weebs and ramen"},
                    new Destination { DestinationId = 4, City = "London", Country = "England", Rating = 3, Review = "Fish n chips mate!"},
                    new Destination { DestinationId = 5, City = "New York", Country = "USA", Rating = 4, Review = "Great Parks and Museums"}
                );

            builder.Entity<Destination2>()
                .HasData(
                    new Destination2 { Destination2Id = 1, City = "Seattle", Country = "USA", Rating = 5 , Review = "Good coffee, scenic bay, awesome market"},
                    new Destination2 { Destination2Id = 2, City = "Paris", Country = "France", Rating = 4, Review = "Bon bageutte"},
                    new Destination2 { Destination2Id = 3, City = "Tokyo", Country = "Japan", Rating = 5, Review = "So many weebs and ramen"},
                    new Destination2 { Destination2Id = 4, City = "London", Country = "England", Rating = 3, Review = "Fish n chips mate!"},
                    new Destination2 { Destination2Id = 5, City = "New York", Country = "USA", Rating = 4, Review = "Great Parks and Museums"}
                );
        }
    }
}