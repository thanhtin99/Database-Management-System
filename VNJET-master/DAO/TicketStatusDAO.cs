using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TicketStatusDAO
    {
        private static TicketStatusDAO instance;
        public static TicketStatusDAO Instance
        {
            get { if (instance == null) instance = new TicketStatusDAO(); return TicketStatusDAO.instance; }
            private set { TicketStatusDAO.instance = value; }
        }

        private TicketStatusDAO()
        { }

        public object GetEmptySeatsByIdFlightAndIdTicketClass(string idFlight, string idTicketClass)
        {
            string query = string.Format("SELECT dbo.UF_GetEmptySeatsByIdFlightAndIdTicketClass('{0}','{1}')", idFlight, idTicketClass);
            object dt = DataProvider.Instance.ExecuteScalar(query);
            return dt;
        }

        public DataTable GetTicketStatusByIdFlight(string IdFlight)
        {
            string query = string.Format("EXEC dbo.USP_GetTicketStatusByIdFlight '{0}'", IdFlight);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool InsertTicketStatus(TicketStatusDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.TicketStatus(idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('{0}', '{1}', {2}, {3})", dto.IdFlights, dto.IdTicketClass, dto.TotalSeats, dto.EmptySeats);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTicketStatus(TicketStatusDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.TicketStatus SET totalSeats = {0}, emptySeats = {1} WHERE idFlights = '{2}' AND idTicketClass = '{3}'", dto.TotalSeats, dto.EmptySeats, dto.IdFlights, dto.IdTicketClass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTicketStatus(TicketStatusDTO dto)
        {
            try
            {
                string query = String.Format("DELETE dbo.TicketStatus WHERE idFlights = '{0}' AND idTicketClass = '{1}'", dto.IdFlights, dto.IdTicketClass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public object CheckSeats(string id)
        {
            string query = string.Format("SELECT dbo.UF_GetSeatsOfPlaneByIdFlight('{0}')", id);
            object dt = DataProvider.Instance.ExecuteScalar(query);
            return dt;
        }
    }
}
