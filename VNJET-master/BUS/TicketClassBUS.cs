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
    public class TicketClassBUS
    {
        

        public DataTable GetForDisplay()
        {
            return TicketClassDAO.Instance.GetForDisplay();
        }

        public DataTable GetTicketClassForFlight(string idFlight)
        {
            return TicketClassDAO.Instance.GetTicketClassForFlight(idFlight);
        }

        public bool InsertTicketClass(TicketClassDTO dto)
        {
            return TicketClassDAO.Instance.InsertTicketClass(dto);
        }
        public bool UpdateTicketClass(TicketClassDTO dto)
        {
            return TicketClassDAO.Instance.UpdateTicketClass(dto);
        }
        public bool DeleteTicketClass(string idTC)
        {
            return TicketClassDAO.Instance.DeleteTicketClass(idTC);
        }
        public DataTable SearchByName(string name)
        {
            return TicketClassDAO.Instance.SearchByName(name);
        }
    }
}
