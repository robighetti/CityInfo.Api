using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities{ get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Piracicaba",
                    Description = "Cidade onde o peixe para",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 5,
                            Name = "Nome qualquer",
                            Description = "Descrição qualquer"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 6,
                            Name = "Nome qualquer",
                            Description = "Descrição qualquer"
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Americana",
                    Description = "Cidade de playboy",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 4,
                            Name = "Nome qualquer",
                            Description = "Descrição qualquer"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 3,
                            Name = "Nome qualquer",
                            Description = "Descrição qualquer"
                        },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Sumaré",
                    Description = "Cidade de maluco",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Nome qualquer",
                            Description = "Descrição qualquer"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Nome qualquer",
                            Description = "Descrição qualquer"
                        },
                    }
                },
            };
        }


    }
}
