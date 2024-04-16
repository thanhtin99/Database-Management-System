using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.Customers ORDER BY idCus";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetByCMND(string CMND)
        {
            string query = String.Format("SELECT * FROM dbo.Customers WHERE identitycardCus = '{0}'", CMND);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
