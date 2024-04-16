using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FlightDAO
    {
        private static FlightDAO instance;
        public static FlightDAO Instance
        {
            get { if (instance == null) instance = new FlightDAO(); return FlightDAO.instance; }
            private set { FlightDAO.instance = value; }
        }

        private FlightDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.Flights ORDER BY idFlights";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetForFlight()
        {
            string query = "SELECT * FROM dbo.Flights ORDER BY idFlights";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetFlightByIdFlight(string idFlight)
        {
            string query = String.Format("EXEC dbo.USP_GetFlightByIdFlight '{0}'", idFlight);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public object GetFlightByAirportAndTime(string idAirportToGo, string idAirportToCome, DateTime thoiGianKHTu, DateTime thoiGianKHDen)
        {
            string query = String.Format("EXEC dbo.USP_GetFlightByAirportAndTime '{0}', '{1}', '{2}', '{3}'", idAirportToGo, idAirportToCome, thoiGianKHTu, thoiGianKHDen);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool InsertFlight(FlightDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.Flights(idFlights, idFlightRoutes, idPlane, timeToGo, timeToCome) VALUES ((SELECT dbo.UF_CreateIdFlight()), '{0}', '{1}', CAST(N'{2}' AS DateTime), CAST(N'{3}' AS DateTime))", dto.IdFlightRoutes, dto.IdPlane, dto.TimeToGo, dto.TimeToCome);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateFlight(FlightDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.Flights SET idFlightRoutes = '{0}', idPlane = '{1}', timeToGo = '{2}', timeToCome = '{3}' WHERE idFlights = '{4}'", dto.IdFlightRoutes, dto.IdPlane, dto.TimeToGo, dto.TimeToCome, dto.IdFlights);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteFlight(string id)
        {
            try
            {
                string query = String.Format("DELETE dbo.Flights WHERE idFlights = '{0}'", id);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchById(string id)
        {
            string query = String.Format("SELECT * FROM dbo.Flights WHERE idFlights LIKE '%'+'{0}'+'%' ORDER BY idFlights", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
