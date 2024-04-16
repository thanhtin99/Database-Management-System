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
    public class PriceBUS
    {
       

        public DataTable GetForDisplay()
        {
            return PriceDAO.Instance.GetForDisplay();
        }
        public object GetPriceByIdFlightAndIdTicketClass(string idFlight, string idTicketClass)
        {
            return PriceDAO.Instance.GetPriceByIdFlightAndIdTicketClass(idFlight, idTicketClass);
        }

        public bool InsertPrice(PriceDTO dto)
        {
            return PriceDAO.Instance.InsertPrice(dto);
        }
        public bool UpdatePrice(PriceDTO dto)
        {
            return PriceDAO.Instance.UpdatePrice(dto);
        }
        public bool DeletePrice(PriceDTO dto)
        {
            return PriceDAO.Instance.DeletePrice(dto);
        }
        public DataTable SearchById(string id)
        {
            return PriceDAO.Instance.SearchById(id);
        }
    }
}
