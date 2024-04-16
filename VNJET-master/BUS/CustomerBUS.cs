using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        public DataTable GetByCMND(string CMND)
        {
            return CustomerDAO.Instance.GetByCMND(CMND);
        }

        public DataTable GetForDisplay()
        {
            return CustomerDAO.Instance.GetForDisplay();
        }
    }
}
