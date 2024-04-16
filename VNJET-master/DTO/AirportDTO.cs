using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AirportDTO
    {
        private string idAirport;
        private string nameAirport;
        private string cityAirport;

        public AirportDTO()
        {
        }

        public AirportDTO(string idAirport, string nameAirport, string cityAirport)
        {
            IdAirport = idAirport;
            NameAirport = nameAirport;
            CityAirport = cityAirport;
        }

        public string IdAirport { get => idAirport; set => idAirport = value; }
        public string NameAirport { get => nameAirport; set => nameAirport = value; }
        public string CityAirport { get => cityAirport; set => cityAirport = value; }
    }
}
