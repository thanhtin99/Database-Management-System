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
    public class TicketStatusBUS
    {
        public object GetEmptySeatsByIdFlightAndIdTicketClass(string IdFlight, string IdTicketClass)
        {
            return TicketStatusDAO.Instance.GetEmptySeatsByIdFlightAndIdTicketClass(IdFlight, IdTicketClass);
        }
        public DataTable GetTicketStatusByIdFlight(string IdFlight)
        {
            return TicketStatusDAO.Instance.GetTicketStatusByIdFlight(IdFlight);

        }
        public bool InsertTicketStatus(TicketStatusDTO dto)
        {
            return TicketStatusDAO.Instance.InsertTicketStatus(dto);
        }

        public bool UpdateTicketStatus(TicketStatusDTO dto)
        {
            return TicketStatusDAO.Instance.UpdateTicketStatus(dto);
        }
        public bool DeleteTicketStatus(TicketStatusDTO dto)
        {
            return TicketStatusDAO.Instance.DeleteTicketStatus(dto);
        }

        public object CheckSeats(string id)
        {
            return TicketStatusDAO.Instance.CheckSeats(id);
        }
    }
}
