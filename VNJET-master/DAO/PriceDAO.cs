using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PriceDAO
    {
        private static PriceDAO instance;
        public static PriceDAO Instance
        {
            get { if (instance == null) instance = new PriceDAO(); return PriceDAO.instance; }
            private set { PriceDAO.instance = value; }
        }

        private PriceDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.Prices";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public object GetPriceByIdFlightAndIdTicketClass(string idFlight, string idTicketClass)
        {
            string query = string.Format("SELECT dbo.UF_GetPriceByIdFlightAndIdTicketClass('{0}','{1}')", idFlight, idTicketClass);
            object dt = DataProvider.Instance.ExecuteScalar(query);
            return dt;
        }

        public bool InsertPrice(PriceDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.Prices(idFlightRoutes,idTicketClass,unitPrice) VALUES ('{0}', '{1}', {2})", dto.IdFlightRoutes, dto.IdTicketClass, dto.UnitPrice);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePrice(PriceDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.Prices SET unitPrice = {0} WHERE idFlightRoutes = '{1}' AND idTicketClass = '{2}'", dto.UnitPrice, dto.IdFlightRoutes, dto.IdTicketClass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePrice(PriceDTO dto)
        {
            try
            {
                string query = String.Format("DELETE dbo.Prices WHERE idFlightRoutes = '{0}' AND idTicketClass = '{1}'", dto.IdFlightRoutes, dto.IdTicketClass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchById(string id)
        {
            string query = String.Format("SELECT * FROM dbo.Prices WHERE idFlightRoutes LIKE '%'+'{0}'+'%'", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
