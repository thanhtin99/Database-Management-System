using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PlaneDAO
    {
        private static PlaneDAO instance;
        public static PlaneDAO Instance
        {
            get { if (instance == null) instance = new PlaneDAO(); return PlaneDAO.instance; }
            private set { PlaneDAO.instance = value; }
        }

        private PlaneDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.Planes";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool DeletePlane(string idPlane)
        {
            try
            {
                string query = String.Format("DELETE dbo.Planes WHERE idPlane='{0}'", idPlane);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertPlane(PlaneDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.Planes(idPlane, namePlane, seatsPlane) VALUES ((SELECT dbo.UF_CreateIdPlane()), N'{0}', {1})", dto.NamePlane, dto.SeatsPlane);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePlane(PlaneDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.Planes SET namePlane = N'{0}', seatsPlane = {1} WHERE idPlane = '{2}'", dto.NamePlane, dto.SeatsPlane, dto.IdPlane);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchByName(string namePlane)
        {
            string query = String.Format("SELECT * FROM dbo.Planes WHERE namePlane LIKE '%'+N'{0}'+'%' ORDER BY idPlane", namePlane);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
