using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.UV_StaffForDisplay ORDER BY idStaffs";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public int CheckLogin(string user, string pass)
        {
            string query = String.Format("SELECT [dbo].UF_Login (N'{0}', N'{1}' )", user, pass);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }

        public bool DeleteStaff(string idStaff)
        {
            try
            {
                string query = String.Format("DELETE dbo.Accounts WHERE idStaffs='{0}'", idStaff);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertStaff(StaffDTO dto)
        {
            try
            {
                string query = String.Format("EXEC dbo.USP_InsertStaff N'{0}', N'{1}', '{2}', '{3}', {4} ", dto.NameStaff, dto.AddressStaff, dto.PhoneStaff, dto.UserAcc, dto.Type);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStaff(StaffDTO dto)
        {
            try
            {
                string query = String.Format("EXEC dbo.USP_UpdateStaff '{0}', N'{1}', N'{2}', '{3}', '{4}', {5} ", dto.IdStaff, dto.NameStaff, dto.AddressStaff, dto.PhoneStaff, dto.UserAcc, dto.Type);
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
            string query = String.Format("EXEC dbo.USP_SearchStaffByName @name = N'{0}'", name);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
