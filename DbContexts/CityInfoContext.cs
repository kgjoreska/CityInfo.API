using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) 
            : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
               new City("Bitola")
               {
                   Id = 1,
                   Description = "The one with the Wide Street."
               },
               new City("Florence")
               {
                   Id = 2,
                   Description = "The one with the beautiful cathedral."
               },
               new City("Paris")
               {
                   Id = 3,
                   Description = "The European gem."
               });

            modelBuilder.Entity<PointOfInterest>()
             .HasData(
               new PointOfInterest("Magnolia Square")
               {
                   Id = 1,
                   CityId = 1,
                   Description = "It is Bitola's town square."
               },
               new PointOfInterest("Wide Street")
               {
                   Id = 2,
                   CityId = 1,
                   Description = "The most famous and visited street in Bitola."
               },
                 new PointOfInterest("Piazza del Duomo")
                 {
                     Id = 3,
                     CityId = 2,
                     Description = "One of Florence’s main symbols."
                 },
               new PointOfInterest("Ponte Vecchio")
               {
                   Id = 4,
                   CityId = 2,
                   Description = "The oldest and most famous bridge in Florence."
               },
               new PointOfInterest("Eiffel Tower")
               {
                   Id = 5,
                   CityId = 3,
                   Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
               },
               new PointOfInterest("The Louvre")
               {
                   Id = 6,
                   CityId = 3,
                   Description = "The world's largest museum."
               }
               );
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
