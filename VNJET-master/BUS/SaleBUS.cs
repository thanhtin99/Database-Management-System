using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SaleBUS
    {
        public DataTable GetForDisplayByTime()
        {
            return SaleDAO.Instance.GetForDisplayByTime();
        }

        public DataTable GetForDisplayByStaff()
        {
            return SaleDAO.Instance.GetForDisplayByStaff();
        }

        public DataTable SaleByTime(int month, int year)
        {
            return SaleDAO.Instance.SaleByTime(month, year);
        }

        public DataTable SaleByIDStaff(string idstaff)
        {
            return SaleDAO.Instance.SaleByIDStaff(idstaff);
        }
    }
}
