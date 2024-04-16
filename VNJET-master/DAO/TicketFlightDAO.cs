using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TicketFlightDAO
    {
        private static TicketFlightDAO instance;
        public static TicketFlightDAO Instance
        {
            get { if (instance == null) instance = new TicketFlightDAO(); return TicketFlightDAO.instance; }
            private set { TicketFlightDAO.instance = value; }
        }

        private TicketFlightDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.UV_TicketFlightForDisplay ORDER BY idTicket";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable SearchByPhone(string phone)
        {
            string query = String.Format("EXEC dbo.USP_SearchTicketFlightByPhone @phone = '{0}'", phone);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool BookingTicket(TicketFlightDTO dtoTicket, CustomerDTO dtoCus)
        {
            try
            {
                string query = String.Format("EXEC dbo.USP_BookingTicket N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}'", dtoCus.NameCus, dtoCus.IdentityCus, dtoCus.PhoneCus, dtoTicket.IdFlights, dtoTicket.IdTicketClass, dtoTicket.IdStaffs);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool CancelTicket(string id)
        {
            try
            {
                string query = String.Format("DELETE dbo.TicketFlights WHERE idTicket = '{0}'", id);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
