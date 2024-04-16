using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FlightDTO
    {
        private string idFlights;
        private string idFlightRoutes;
        private string idPlane;
        private DateTime timeToGo;
        private DateTime timeToCome;

        public FlightDTO()
        {
        }

        public FlightDTO(string idFlights, string idFlightRoutes, string idPlane, DateTime timeToGo, DateTime timeToCome)
        {
            IdFlights = idFlights;
            IdFlightRoutes = idFlightRoutes;
            IdPlane = idPlane;
            TimeToGo = timeToGo;
            TimeToCome = timeToCome;
        }

        public string IdFlights { get => idFlights; set => idFlights = value; }
        public string IdFlightRoutes { get => idFlightRoutes; set => idFlightRoutes = value; }
        public string IdPlane { get => idPlane; set => idPlane = value; }
        public DateTime TimeToGo { get => timeToGo; set => timeToGo = value; }
        public DateTime TimeToCome { get => timeToCome; set => timeToCome = value; }
    }
}
