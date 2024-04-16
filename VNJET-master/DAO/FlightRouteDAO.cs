using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FlightRouteDAO
    {
        private static FlightRouteDAO instance;
        public static FlightRouteDAO Instance
        {
            get { if (instance == null) instance = new FlightRouteDAO(); return FlightRouteDAO.instance; }
            private set { FlightRouteDAO.instance = value; }
        }

        private FlightRouteDAO()
        { }
        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM UV_FlightRouteForDisplay ORDER BY idFlightRoutes";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetOfIdFlightRoute(string str)
        {
            string query = String.Format("SELECT * FROM UV_FlightRouteForDisplay WHERE idFlightRoutes = '{0}'", str);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetOfIdAirport(string idToGo, string idToCome)
        {
            string query = String.Format("SELECT * FROM dbo.FlightRoutes\r\n" +
                "WHERE idAirportToGo = '{0}' AND idAirportToCome = '{1}'", idToGo, idToCome);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool InsertFlightRoute(FlightRouteDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.FlightRoutes(idFlightRoutes, idAirportToGo, idAirportToCome) VALUES ((SELECT dbo.UF_CreateIdFlightRoute()), '{0}', '{1}')", dto.IdAirportToGo, dto.IdAirportToCome);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateFlightRoute(FlightRouteDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.FlightRoutes SET idAirportToGo = '{0}', idAirportToCome = '{1}' WHERE idFlightRoutes = '{2}'", dto.IdAirportToGo, dto.IdAirportToCome, dto.IdFlightRoutes);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteFlightRoute(string idFR)
        {
            try
            {
                string query = String.Format("DELETE dbo.FlightRoutes WHERE idFlightRoutes = '{0}'", idFR);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchByName(string name)
        {
            string query = String.Format("SELECT * FROM dbo.UV_FlightRouteForDisplay WHERE nameAirportToGo LIKE '%'+N'{0}'+'%' OR nameAirportToCome LIKE '%'+N'{1}'+'%' ORDER BY idFlightRoutes", name, name);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
