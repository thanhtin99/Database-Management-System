using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FlightRouteDTO
    {
        private string idFlightRoutes;
        private string idAirportToGo;
        private string idAirportToCome;

        public FlightRouteDTO()
        {
        }

        public FlightRouteDTO(string idFlightRoutes, string idAirportToGo, string idAirportToCome)
        {
            IdFlightRoutes = idFlightRoutes;
            IdAirportToGo = idAirportToGo;
            IdAirportToCome = idAirportToCome;
        }

        public string IdFlightRoutes { get => idFlightRoutes; set => idFlightRoutes = value; }
        public string IdAirportToGo { get => idAirportToGo; set => idAirportToGo = value; }
        public string IdAirportToCome { get => idAirportToCome; set => idAirportToCome = value; }
    }
}
