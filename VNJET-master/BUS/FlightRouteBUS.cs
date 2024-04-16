using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FlightRouteBUS
    {
       

        public DataTable GetForDisplay()
        {
            return FlightRouteDAO.Instance.GetForDisplay();
        }

        public DataTable GetOfIdAirport(string idToGo, string idToCome)
        {
            return FlightRouteDAO.Instance.GetOfIdAirport(idToGo, idToCome);
        }

        public DataTable GetOfIdFlightRoute(string str)
        {
            return FlightRouteDAO.Instance.GetOfIdFlightRoute(str);
        }

        public bool InsertFlightRoute(FlightRouteDTO dto)
        {
            return FlightRouteDAO.Instance.InsertFlightRoute(dto);
        }

        public bool UpdateFlightRoute(FlightRouteDTO dto)
        {
            return FlightRouteDAO.Instance.UpdateFlightRoute(dto);
        }
        public bool DeleteFlightRoute(string idFR)
        {
            return FlightRouteDAO.Instance.DeleteFlightRoute(idFR);
        }
        public DataTable SearchByName(string name)
        {
            return FlightRouteDAO.Instance.SearchByName(name);
        }
    }
}
