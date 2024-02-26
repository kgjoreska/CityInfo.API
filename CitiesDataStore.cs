using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
       // public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                     Id = 1,
                     Name = "Bitola",
                     Description = "The one with the Wide Street.",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 1,
                             Name = "Magnolia Square",
                             Description = "It's Bitola's town square." },
                          new PointOfInterestDto() {
                             Id = 2,
                             Name = "Wide Street",
                             Description = "The most famous and visited street in Bitola." },
                     }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Florence",
                    Description = "The one with the beautiful cathedral.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 3,
                             Name = "Piazza del Duomo",
                             Description = "One of Florence’s main symbols." },
                          new PointOfInterestDto() {
                             Id = 4,
                             Name = "Ponte Vecchion",
                             Description = "The oldest and most famous bridge in Florence." },
                     }
                },
                new CityDto()
                {
                    Id= 3,
                    Name = "Paris",
                    Description = "The European gem",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 5,
                             Name = "Eiffel Tower",
                             Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel." },
                          new PointOfInterestDto() {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The world's largest museum." },
                     }
                }
            };

        }

    }
}
