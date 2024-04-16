using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PriceDTO
    {
        private string idFlightRoutes;
        private string idTicketClass;
        private long unitPrice;

        public PriceDTO()
        {
        }

        public PriceDTO(string idFlightRoutes, string idTicketClass, long unitPrice)
        {
            IdFlightRoutes = idFlightRoutes;
            IdTicketClass = idTicketClass;
            UnitPrice = unitPrice;
            UnitPrice = unitPrice;
            IdTicketClass = idTicketClass;
            IdFlightRoutes = idFlightRoutes;
        }

        public long UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string IdTicketClass { get => idTicketClass; set => idTicketClass = value; }
        public string IdFlightRoutes { get => idFlightRoutes; set => idFlightRoutes = value; }
    }
}
