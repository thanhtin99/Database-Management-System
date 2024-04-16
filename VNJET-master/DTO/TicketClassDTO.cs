using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TicketClassDTO
    {
        private string idTicketClass;
        private string nameTicketClass;

        public TicketClassDTO()
        {
        }

        public TicketClassDTO(string idTicketClass, string nameTicketClass)
        {
            IdTicketClass = idTicketClass;
            NameTicketClass = nameTicketClass;
        }

        public string IdTicketClass { get => idTicketClass; set => idTicketClass = value; }
        public string NameTicketClass { get => nameTicketClass; set => nameTicketClass = value; }
    }
}
