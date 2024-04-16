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
    public class FlightBUS
    {
        public DataTable GetForDisplay()
        {
            return FlightDAO.Instance.GetForDisplay();
        }
        public DataTable GetFlightByIdFlight(string idFlight)
        {
            return FlightDAO.Instance.GetFlightByIdFlight(idFlight);
        }

        public object GetFlightByAirportAndTime(string idAirportToGo, string idAirportToCome, DateTime thoiGianKHTu, DateTime thoiGianKHDen)
        {
            return FlightDAO.Instance.GetFlightByAirportAndTime(idAirportToGo, idAirportToCome, thoiGianKHTu, thoiGianKHDen);
        }

        public bool InsertFlight(FlightDTO dto)
        {
            return FlightDAO.Instance.InsertFlight(dto);
        }

        public bool UpdateFlight(FlightDTO dto)
        {
            return FlightDAO.Instance.UpdateFlight(dto);
        }

        public bool DeleteFlight(string id)
        {
            return FlightDAO.Instance.DeleteFlight(id);
        }

        public DataTable SearchById(string id)
        {
            return FlightDAO.Instance.SearchById(id);
        }
    }
}
