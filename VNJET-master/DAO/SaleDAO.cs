using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SaleDAO
    {
        private static SaleDAO instance;
        public static SaleDAO Instance
        {
            get { if (instance == null) instance = new SaleDAO(); return SaleDAO.instance; }
            private set { SaleDAO.instance = value; }
        }

        private SaleDAO()
        { }
        public DataTable GetForDisplayByTime()
        {
            string query = "SELECT * FROM dbo.Sales ORDER BY yearSales";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetForDisplayByStaff()
        {
            string query = "SELECT * FROM dbo.UV_SaleByStaff ORDER BY idStaffs";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable SaleByTime(int month, int year)
        {
            string query = String.Format("SELECT * FROM dbo.Sales WHERE monthSales = {0} AND yearSales = {1} ORDER BY yearSales", month, year);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable SaleByIDStaff(string idstaff)
        {
            string query = String.Format("SELECT * FROM dbo.UV_SaleByStaff WHERE idStaffs = '{0}' ORDER BY idStaffs", idstaff);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
