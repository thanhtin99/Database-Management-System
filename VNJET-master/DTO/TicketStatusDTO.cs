using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TicketStatusDTO
    {
        private string idFlights;
        private string idTicketClass;
        private int totalSeats;
        private int emptySeats;

        public TicketStatusDTO()
        {
        }

        public TicketStatusDTO(string idFlights, string idTicketClass, int totalSeats, int emptySeats)
        {
            IdFlights = idFlights;
            IdTicketClass = idTicketClass;
            TotalSeats = totalSeats;
            EmptySeats = emptySeats;
        }

        public string IdFlights { get => idFlights; set => idFlights = value; }
        public string IdTicketClass { get => idTicketClass; set => idTicketClass = value; }
        public int TotalSeats { get => totalSeats; set => totalSeats = value; }
        public int EmptySeats { get => emptySeats; set => emptySeats = value; }
    }
}
