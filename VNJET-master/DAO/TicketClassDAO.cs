using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TicketClassDAO
    {
        private static TicketClassDAO instance;
        public static TicketClassDAO Instance
        {
            get { if (instance == null) instance = new TicketClassDAO(); return TicketClassDAO.instance; }
            private set { TicketClassDAO.instance = value; }
        }

        private TicketClassDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.TicketClasses";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetTicketClassForFlight(string idFlight)
        {
            string query = string.Format("EXEC dbo.USP_GetTicketClassForFlight '{0}'", idFlight);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool InsertTicketClass(TicketClassDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.TicketClasses(idTicketClass, nameTicketClass) VALUES ((SELECT dbo.UF_CreateIdTicketClass()), N'{0}')", dto.NameTicketClass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTicketClass(TicketClassDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.TicketClasses SET nameTicketClass = N'{0}' WHERE idTicketClass = '{1}'", dto.NameTicketClass, dto.IdTicketClass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTicketClass(string idTC)
        {
            try
            {
                string query = String.Format("DELETE dbo.TicketClasses WHERE idTicketClass = '{0}'", idTC);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchByName(string name)
        {
            string query = string.Format("SELECT * FROM dbo.TicketClasses WHERE nameTicketClass LIKE '%'+N'{0}'+'%'", name);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
