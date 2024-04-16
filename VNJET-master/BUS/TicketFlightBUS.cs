using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TicketFlightBUS
    {
        public DataTable GetForDisplay()
        {
            return TicketFlightDAO.Instance.GetForDisplay();
        }

        public DataTable SearchByPhone(string phone)
        {
            return TicketFlightDAO.Instance.SearchByPhone(phone);
        }
        public bool BookingTicket(TicketFlightDTO dtoTicket, CustomerDTO dtoCus)
        {
            return TicketFlightDAO.Instance.BookingTicket(dtoTicket, dtoCus);
        }

        public bool CancelTicket(string id)
        {
            return TicketFlightDAO.Instance.CancelTicket(id);
        }
    }
}
