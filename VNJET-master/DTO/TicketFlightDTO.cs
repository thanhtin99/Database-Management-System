using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TicketFlightDTO
    {
        private string idTicket;
        private string idCus;
        private string idFlights;
        private string idTicketClass;
        private string idStaffs;
        private decimal price;

        public TicketFlightDTO()
        {
        }

        public TicketFlightDTO(string idTicket, string idCus, string idFlights, string idTicketClass, string idStaffs, decimal price)
        {
            IdTicket = idTicket;
            IdCus = idCus;
            IdFlights = idFlights;
            IdTicketClass = idTicketClass;
            IdStaffs = idStaffs;
            Price = price;
        }

        public string IdTicket { get => idTicket; set => idTicket = value; }
        public string IdCus { get => idCus; set => idCus = value; }
        public string IdFlights { get => idFlights; set => idFlights = value; }
        public string IdTicketClass { get => idTicketClass; set => idTicketClass = value; }
        public string IdStaffs { get => idStaffs; set => idStaffs = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
